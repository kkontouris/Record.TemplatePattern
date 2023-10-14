namespace TemplatePattern.Record
{
    // Generic abstract class defining the template method
    abstract class Record<T>
    {
        //static list to restore records
        private static List<T> records = new List<T>();

        //this is the template method that defining the algorithm
        public void Save()
        {
            this.Validate();
            this.BeforeSave();

            this.SaveToList();
        }

        // Abstract method to get the data to save
        protected abstract T GetDataToSave();

        protected abstract void Validate();

        //hook method
        protected virtual void BeforeSave()
        {
            Console.WriteLine("This is before saving");
        }
        //save to a list and this can b edefined in subclasses
        protected void SaveToList()
        {
            records.Add(GetDataToSave());
            Console.WriteLine($"Saving the {GetDataToSave()} in the list");
        }


        // Method to get the records list
        public static List<T> GetRecordList()
        {
            return records;
        }

    }

}