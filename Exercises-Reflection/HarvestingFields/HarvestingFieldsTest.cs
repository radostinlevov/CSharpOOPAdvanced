namespace _01HarestingFields
{
    using System.Reflection;
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type fieldType = typeof(HarvestingFields);

            var fields = fieldType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            string inputLine = Console.ReadLine();

            while (inputLine != "HARVEST")
            {
                switch (inputLine)
                {
                    case "private":

                        foreach (var field in fields)
                        {
                            if (field.IsPrivate)
                            {
                                Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                            }
                        }

                        break;

                    case "public":

                        foreach (var field in fields)
                        {
                            if (field.IsPublic)
                            {
                                Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                            }
                        }

                        break;

                    case "protected":

                        foreach (var field in fields)
                        {
                            if (field.IsFamily)
                            {
                                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                            }
                        }

                        break;

                    case "all":

                        foreach (var field in fields)
                        {
                            if (field.IsPrivate)
                            {
                                Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                            }
                            else if (field.IsPublic)
                            {
                                Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                            }
                            else if (field.IsFamily)
                            {
                                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                            }
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
