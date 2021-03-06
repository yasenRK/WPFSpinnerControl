﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSpinnerControl.EditableTitle
{
    class EditableTitleViewModel : BindableBase
    {
        

        public EditableTitleViewModel()
        {
            EditTitleCommand = new RelayCommand(EditTitle);
            SaveModificationsCommand = new RelayCommand(SaveModifications);
            CancelModificationsCommand = new RelayCommand(CancelModifications);
            ClearTextCommand = new RelayCommand(ClearText);

            Text = "Prévoir les demandes de dé-raccordement auprès des concessionnaires public";
        }

        private void ClearText()
        {
            EditedText = "";
        }

        private void CancelModifications()
        {
            EditableMode = false;
        }

        private void SaveModifications()
        {
            EditableMode = false;
            Text = EditedText;
        }

        private void EditTitle()
        {
            EditableMode = true;
            EditedText = Text;
        }

        private string _editedText;
        public string EditedText
        {
            get { return _editedText; }
            set { SetProperty(ref _editedText, value); }
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private bool _editableMode;
        public bool EditableMode
        {
            get { return _editableMode; }
            set { SetProperty(ref _editableMode, value); }
        }

        public RelayCommand EditTitleCommand { get; private set; }
        public RelayCommand SaveModificationsCommand { get; private set; }
        public RelayCommand CancelModificationsCommand { get; private set; }
        public RelayCommand ClearTextCommand { get; private set; }
    }
}
