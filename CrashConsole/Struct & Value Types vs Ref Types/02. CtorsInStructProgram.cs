// Constructors in Structures - working with parameter-less & parameterized constructors in structures.
// Note: Structure won't allow to create parameterised ctor only if you initialise all fields else it will return compile time error.
namespace demo
{
    public struct Category
    {
        public Category(int catID, string catName)
        {
            _categoryID = catID;
            _categoryName = catName; // if i miss anyone it retun error.
        }

        private int _categoryID;
        public int CategoryID
        {
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _categoryID = value;
                }
            }
            get
            {
                return _categoryID;
            }
        }

        private string _categoryName;
        public string CategoryName
        {
            set
            {
                if (value.Length <= 40)
                {
                    _categoryName = value;
                }
            }
            get
            {
                return _categoryName;
            }
        }
    }


    public class StructAndValueAndRefTypesProgram
    {
        public static void Mainb()
        {
            // create structure instance
            Category category = new Category(20, "Dummy Test"); 
            
            // here new keyword is used not to create obj but a dummy for calling a pmterless ctor.
        }
    }
}
