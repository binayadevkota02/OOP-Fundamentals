string filePath = @"C:\Users\binaya.raj_teksewa\Desktop\OOP fundamental\OOP-Fundamentals\Assignment\Assignment5\";
List<Person> people = await CSVParser.ParseCSV(filePath);
await PeopleReport.SaveMales(people, filePath);
await PeopleReport.SaveFemales(people, filePath);
await PeopleReport.SaveDotComUsers(people, filePath);