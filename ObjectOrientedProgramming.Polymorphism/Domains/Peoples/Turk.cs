namespace ObjectOrientedProgramming.Polymorphism.Domains.Peoples
{
    internal class Turk : People
    {
        public override void Salutation() // ovveride (ezmek, üstüne geçmek)
        {
            base.Salutation();  // ana classtaki virtual metodu olduğu gibi kullandım.
        }
    }
}
