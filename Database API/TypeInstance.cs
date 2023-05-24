namespace Database_API
{
    public class TypeInstance
    {
        public IType returnInstance;

        public IType GetType(string Type)
        {
            if (Type.ToLower().Equals("fruit"))
            {
                returnInstance = new Fruit();


            }
            else if (Type.ToLower().Equals("vegetable"))
            {
                returnInstance = new Vegetable();
            }
            else if (Type.ToLower().Equals("Dairy"))
            {
                returnInstance = new Dairy();
            }

            return returnInstance;
        }
    }
}
