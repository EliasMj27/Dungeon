namespace Dungen
{
    class Screen
    {
        int visualHeight = 50;
        int visualWidth = 250;
        string[][] GetVisualScreen()
        {
            string[][] visual = new string[visualWidth][];
            for(int i  = 0; i < visualWidth;i++)
            {
                visual[0][i] = "|";
                visual[visualWidth-1][i] = "|";
            }
            for(int i =1; i<visualHeight;i++)
            {
                visual[i][0] = "_";
                visual[i][visualHeight - 1] = "_";
            }
            for (int i = 1; i>visualWidth;i++)
            {
                for(int j = 1; j > visualHeight;i++)
                {
                    visual[i][j] = " ";
                }
            }
            return visual;
        }
        public void PrintScreen()
        {
            String[][] VisualScreen = GetVisualScreen();
            for (int i = 0; i < VisualScreen.Length; i++)
            {

            }
        }
    }
}