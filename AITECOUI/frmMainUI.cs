using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AITECOUI
{
    public partial class frmMainUI : Form
    {
        public frmMainUI()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void frmMainUI_Load(object sender, EventArgs e)
        {
            txtLLM.Text = "https://249e-35-236-212-91.ngrok-free.app/generate_response";
            txtOpenAI.Text = "https://249e-35-236-212-91.ngrok-free.app/generate_response";
        }

        private async void btnGenerateCodeFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSavetoFile_Click(object sender, EventArgs e)
        {
            
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            if (txtInput.Text== "Describe the test scenario you want to create")
            {
                txtInput.Clear();
                txtInput.ForeColor = Color.Black;
            }
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                txtInput.Text= "Describe the test scenario you want to create";
                txtInput.ForeColor = Color.Gray;
            }
        }
        public class AIResultModel
        {
            public string response { get; set; }
        }

        public class AIRequestModel
        {
            public string userQuery { get; set; }
        }

        private void processAIResult(string aiResult, char lineBreak)
        {
            string[] aiResponseArray = aiResult.Split(lineBreak);
            foreach (var line in aiResponseArray)
            {
                rtbOutput.Text += line + '\n';
            }
        }

        private void processAIResult(string aiResult)
        {
            rtbOutput.Text = aiResult;
        }

        private async void lblGenerateBtn_Click(object sender, EventArgs e)
        {
            string content = GenerateContentFromAI();

            if (rbOpenAI.Checked)
            {
                processAIResult(content);
            }
            if (rbLLM.Checked)
            {
                processAIResult(content, '$');
            }
        }

        private string GenerateContentFromAI()
        {
            string url = "";
            if (rbOpenAI.Checked)
            {
                url=txtOpenAI.Text;
            }
            if (rbLLM.Checked)
            {
                url = txtLLM.Text;
            }

            var payload = new AIRequestModel()
            {
                userQuery = txtInput.Text
            };

            // Serialize the object to JSON
            string jsonPayload = JsonConvert.SerializeObject(payload);

            using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMinutes(10) })
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = client.PostAsync(url, content).Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    AIResultModel aiResult = JsonConvert.DeserializeObject<AIResultModel>(responseBody);
                    return aiResult.response.Replace("```csharp","").Replace("```","");
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void lblGenerateBtn_MouseHover(object sender, EventArgs e)
        {
            lblGenerateBtn.Image = AITECOUI.Properties.Resources.G2;
        }

        private void lblGenerateBtn_MouseLeave(object sender, EventArgs e)
        {
            lblGenerateBtn.Image = AITECOUI.Properties.Resources.G1;
        }

        private void lblCreateFileBtn_MouseHover(object sender, EventArgs e)
        {
            lblCreateFileBtn.Image = AITECOUI.Properties.Resources.C22;
        }

        private void lblCreateFileBtn_MouseLeave(object sender, EventArgs e)
        {
            lblCreateFileBtn.Image = AITECOUI.Properties.Resources.C11;
        }

        private void lblCreateFileBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "C# code files (*.cs)|*.cs|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Close();
                    File.WriteAllText(saveFileDialog.FileName, rtbOutput.Text);
                }
            }
        }

        private void lblCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|void|foreach|in)\b";
            MatchCollection keywordMatches = Regex.Matches(rtbOutput.Text, keywords);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(rtbOutput.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(rtbOutput.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(rtbOutput.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = rtbOutput.SelectionStart;
            int originalLength = rtbOutput.SelectionLength;
            Color originalColor = Color.Black;

            // removes any previous highlighting (so modified words won't remain highlighted)
            rtbOutput.SelectionStart = 0;
            rtbOutput.SelectionLength = rtbOutput.Text.Length;
            rtbOutput.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                rtbOutput.SelectionStart = m.Index;
                rtbOutput.SelectionLength = m.Length;
                rtbOutput.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                rtbOutput.SelectionStart = m.Index;
                rtbOutput.SelectionLength = m.Length;
                rtbOutput.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                rtbOutput.SelectionStart = m.Index;
                rtbOutput.SelectionLength = m.Length;
                rtbOutput.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                rtbOutput.SelectionStart = m.Index;
                rtbOutput.SelectionLength = m.Length;
                rtbOutput.SelectionColor = Color.Brown;
            }

            // restoring the original colors, for further writing
            rtbOutput.SelectionStart = originalIndex;
            rtbOutput.SelectionLength = originalLength;
            rtbOutput.SelectionColor = originalColor;

            // giving back the focus
            rtbOutput.Focus();
        }

        private void lblShowHideCtrl_Click(object sender, EventArgs e)
        {
            if (rbLLM.Visible == true) { rbLLM.Visible = false; } else { rbLLM.Visible = true; }
            if (txtLLM.Visible == true) { txtLLM.Visible = false; } else { txtLLM.Visible = true; }
            if (rbOpenAI.Visible == true) { rbOpenAI.Visible = false; }else { rbOpenAI.Visible = true; }
            if (txtOpenAI.Visible == true) { txtOpenAI.Visible = false; } else { txtOpenAI.Visible = true; }
        }
    }
}
