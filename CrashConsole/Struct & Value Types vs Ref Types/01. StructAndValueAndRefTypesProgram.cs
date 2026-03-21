/* Value Types & Ref Types */
/*

Value Types: Structures, Enumerations -- Stack (instance)
Reference Types: string, Classes, Interfaces, Delegates -- Heap (objects)

Note: Structure are little bit faster (stores data in stack) than classes (stores data in heap) so if you have 1 or 2 fields then use structure but also keep in mind structure dont support inheritance. Cannot create obj and ref variable for structure.
*/

public struct Category
{
    private int _categoryID;
    public int CategoryID
    {
        set
        {
            if(value >= 1 && value <= 100)
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
            if(value.Length <= 40)
            {
                _categoryName = value;
            }
        }
        get
        {
            return _categoryName;
        }
    }

    public string getCategoryLength()
    {
        return this._categoryName.Length.ToString();
    }
}




public class StructAndValueAndRefTypesProgram
{
    public static void Mainp()
    {
        // create structure instance
        Category category = new Category(); // here new keyword is used not to create obj but
                                            // a dummy for calling a pmterless ctor.
        category.CategoryID = 20;
        category.CategoryName = "Dummy Test";

        Console.WriteLine("Result - "+"ID: "+category.CategoryID+" | Age: "+category.CategoryName+ " | Category Name Length is: "+ category.getCategoryLength());
    }
}