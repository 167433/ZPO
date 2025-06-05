Pomysł był ambitny i wraz z pracą nad nim zaczął się rozwijać ale nie skończyłbym wersji porządnej i faktycznie użytkowej na czas, jest więc wersja pokazująca możliwości

Również nei zauważyłem, że moje komity z VS nie wychodzą bo nie miałem ustawionej auto synchronizacji dlatego projekt wrzucony praktycznie cały w jeden dzień.

Dziedziczenie jest w playerCharacter po Character(abstrakcyjna)
Polimorfiz Character ma pola protected (UWAGA!!! za późno się zorientowałem że nie będą się zapisywać do JSON. Nie mam pomysłu jak inaczej przedstawić polimorfizm :/  )
Własny typ wyjątków ExceptionGeralt, Imię nie może być "Geralt"
Obsługa wyjątków w warstwie logiki i prezentacji, nie można zapisać postaci która ma puste imię
Agregacja w playerCharacter List<GameClass>
Kompozycja w playerCharacter BackStory (wpisane na sztywno dla testów)
Użycie co najmniej jednej struktury kolekcji generycznej (np. List<T>, Dictionary<TKey, TValue>)  dodałem Ekwipunek na przycisku z czasem można by się pokusić o oddzielne klasy ewkipunku np. miecze, łuki itp.
Użycie zapytań LINQ do operacji na danych Tutaj miałem problem żeby wymyślić zastosowanie, jest więc funkcja która z wybranch klas zwraca ilość tych które zawierają słowo "mag" żeby zwrócić ilość opisów które mogą dotyczyć magii
Zapis i odczyt danych z pliku w formacie JSON lub XML, wszystko stoi na JSON, jest JSON config który ustala kolor tła, jest JSON z rasam i Klasami oraz zapis postaci do JSON
