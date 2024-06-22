
namespace EnComponentStore.Core.Abstractions
{
    /// <summary>
    /// Интерфейс с описанием компаний
    /// </summary>
    /// 


    interface ICompany
    {    

    string name { get; set; }

    string role { get; set; }

    string minName { get; set; }

    string inn { get; set; } 

    string ogrn { get; set; }

    string legalAddress { get; set; }

    string mailingAddress { get; set; }

    string emailAddress { get; set; }

    string phone { get; set; }

    string boss { get; set;}

    string nameBoss  { get; set; }

    string bikBank { get; set; }

    string  accountBank { get; set; }

    }  
}