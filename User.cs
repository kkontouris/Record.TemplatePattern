namespace TemplatePattern.Record
{
    class User<T> : Record<T>
    {
        public T ValueToSave { get; set; }


        // Concrete implementation of getting data to save (in this case, an integer)
        protected override T GetDataToSave()
        {
            return ValueToSave;
        }


        protected override void Validate()
        {
            Console.WriteLine($"We have validated {GetDataToSave()}");
        }
    }

}