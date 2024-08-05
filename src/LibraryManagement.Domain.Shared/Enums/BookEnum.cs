using System;
namespace LibraryManagement.Enums;

public enum BookGenre
{
    Fiction,
    NonFiction,
    ScienceFiction,
    Mystery,
    Biography,
    History,
    SelfHelp,
    Romance,
    Fantasy,
    Horror,
    Thriller,
    Poetry,
    Children,
    Academic,
    Reference,
    Undefined
}

public enum BookFormat
{
    Hardcover,
    Paperback,
    Ebook,
    AudioBook,
    LargePrint
}

public enum BookStatus
{
    Available,
    Borrowed,
    Reserved,
    UnderMaintenance,
    Lost
}