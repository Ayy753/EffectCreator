using System.Collections.Generic;
using System.Windows.Forms;

namespace EffectCreator {
    public static class RowValidator {
        public enum ValidationError {
            None,
            NameEmpty,
            DuplicateName
        }

        public static ValidationError ValidateName(string rowName, List<string> existingNames) {
            if (string.IsNullOrWhiteSpace(rowName)) {
                return ValidationError.NameEmpty;
            }
            else if (NameExists(rowName, existingNames)) {
                return ValidationError.DuplicateName;
            }
            else {
                return ValidationError.None;
            }
        }

        private static bool NameExists(string rowName, List<string> existingNames) {
            foreach (string name in existingNames) {
                if (name == rowName) {
                    return true;
                }            
            }
            return false;
        }

        public static void DisplayNameErrorMessage(ValidationError validationError, string rowName) {
            if (validationError == ValidationError.NameEmpty) {
                MessageBox.Show($"The row name cannot be empty.",
                    "Row Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validationError == ValidationError.DuplicateName) {
                MessageBox.Show($"The name '{rowName}' already exists for this collection, please choose another.",
                    "Row Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
