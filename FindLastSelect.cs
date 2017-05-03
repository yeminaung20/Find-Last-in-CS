private void btnString_Click(object sender, EventArgs e)
        {
            
            String sOriginal = txtString.Text.ToString();
            char result = funLastSelect(sOriginal);
            string sPrint = result.ToString();
            MessageBox.Show(sPrint);
            
        }
        public char funLastSelect(string sOriginal)
        {
            char LastSelect = '0';
            char[] Select;
            Select = new char[sOriginal.Length];
            int iFirst = 0;
            foreach (char c in sOriginal)
            {
                if (c == '/')
                {
                    Select[iFirst++] = c;
                }
            }
            char[] ClearZero;
            ClearZero = new char[iFirst];
            for (int i = 0; i < iFirst; i++)
            {
                ClearZero[i] = Select[i];
            }
            char[] cFirstSet;
            cFirstSet = new char[iFirst - 1];
            for (int i = 0; i < iFirst - 1; i++)
            {
                cFirstSet[i] = ClearZero[i];
            }
            char[] cLastSet;
            cLastSet = new char[(ClearZero.Length) - (cFirstSet.Length)];
            for (int i = 0; i < (ClearZero.Length) - (cFirstSet.Length); i++)
            {
                cLastSet[i] = ClearZero[cFirstSet.Length];
            }
            LastSelect = cLastSet[0];
        return LastSelect;
        }
