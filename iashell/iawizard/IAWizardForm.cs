using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDK.Gui;

namespace iawizard
{
   

    public partial class IAWizardForm : Form
    {
        private IDK.Gui.Wizard.Wizard FMMWizard;
        private IDK.Gui.Wizard.WizardPage WelcomePage;
        private IDK.Gui.Wizard.InfoContainer infoContainer1;

        private IDK.Gui.Wizard.WizardPage wpAlternateFinish;
        private IDK.Gui.Wizard.InfoContainer infoContainerOptionsPage;

        private IDK.Gui.Wizard.WizardPage wizardPagePassword;
        private IDK.Gui.Wizard.Header header7;

        public IAWizardForm()
        {
            InitializeComponent();
        }
    }
}
