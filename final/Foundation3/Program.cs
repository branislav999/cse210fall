using System;

class Program
{
    static void Main()
    {
        Address _eventAddress = new Address("General Draza Mihailovic Street", 42, "Belgrade", "Vojvodina", "Serbia");

        Event _standardEvent = new Event("Standard Event", "A generic event", "2023-01-01", "12:00 PM", _eventAddress);
        Lecture _lectureEvent = new Lecture("Tech Talk", "Learn about new technologies", "2023-02-15", "3:00 PM", _eventAddress, "Matija Pavlovic", 100);
        Reception _receptionEvent = new Reception("Networking Mixer", "Socialize and network", "2023-03-20", "6:00 PM", _eventAddress, "register.com");
        Outdoor _outdoorEvent = new Outdoor("Summer Picnic", "Enjoy outdoor activities", "2023-06-10", "1:00 PM", _eventAddress, 75);

        _standardEvent.BasicDisplay();
        _lectureEvent.FullDisplay();
        _receptionEvent.FullDisplay();
        _outdoorEvent.FullDisplay();
    }
}
