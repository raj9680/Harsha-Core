namespace SwitchCase
{
    public class Switch
    {
        public string SwitchCase()
        {
            char gradeLetter = 'A';
            string gradeDescription;
            switch(gradeLetter)
            {
                case 'A':
                    gradeDescription = "Outstanding"; 
                    break;
                case 'B':
                    gradeDescription = "Average";
                    break;
                default:
                    gradeDescription = "Fail";
                    break;
            }

            return gradeDescription;
        }
    }
}
