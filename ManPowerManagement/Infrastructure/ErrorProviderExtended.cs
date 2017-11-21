using ManPowerManagement.Infrastructure;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ManPowerManagement.Infrastructure
{
    public class ErrorProviderExtended:ErrorProvider
    {
        private ValidationControlCollection _validationcontrols = new ValidationControlCollection();

        private string _summarymessage = "Please enter data for following mandatory fields - ";
        //This property will be used for displaying a summary message about all empty fields
        //Default value is "Please enter following mandatory fields,". You can set any other 
        //message using this property.
        public string SummaryMessage
        {
            get { return _summarymessage; }
            set { _summarymessage = value; }
        }

        //Controls property is of type ValidationControlCollection which is inherited from CollectionBase 
        //Controls holds all those objects which should be validated.
        public ValidationControlCollection Controls
        {
            get{return _validationcontrols;}
            set { _validationcontrols = value;}
        }
    }
    //Following class is inherited from CollectionBase class. It is used for holding all Validation Controls.
    //This class is collection of ValidationControl class objects.
    //This class is used by ErrorProviderExtended class.

    #region ValidationControlCollection
    public class ValidationControlCollection : CollectionBase
    {
        public ValidationControlCollection()
        {

        }
    }
    
    #endregion


    /* ValidationControl class is used to hold any control from windows form. 
       It holds any control in ControlObj property.
     * */
    #region ValidationControl

    public class ValidationControl
    {
        private Control _control;
        private string _displayname;
        private string _errormessage;
        private string _customErrorMessage;
        private bool _validate = true;

        //Validate property decides weather control is to be validated. Default value is TRUE.
        public bool Validate {
            get { return _validate; }
            set { _validate = value; }
        }

        //ControlObj is a control from windows form which is to be validated.
        //For example txtStudentName
        public Control ControlObj
        {
            get { return _control; }
            set { _control = value; }
        }

        //DisplayName property is used for displaying summary message to user.
        //For example, for txtStudentName you can set 'Student Full Name' as field name.
        //This field name will be displayed in summary message.
        public string DisplayName
        {
            get { return _displayname; }
            set { _displayname = value; }
        }

        //ErrorMessage is also used for displaying summary message.
        //For example, you can enter 'Student Name is mandatory' as an error message.
        public string ErrorMessage
        {
            get { return _errormessage; }
            set { _errormessage = value; }
        }

        public string CustomErrorMessage
        {
            get { return _customErrorMessage; }
            set { _customErrorMessage = value; }
        }
    }
    #endregion
}
