using System;

namespace retest.models
{
  public class job
  {
    public decimal Salary { get; set; }

    public string Title { get; set; }

    public string Company { get; set; }

    public string Id { get; set; }


    job()
    {
      Id = Guid.NewGuid().ToString();
    }

    public job(decimal salary, string title, string company)
    {
      Salary = salary;
      Title = title;
      Company = company;
      Id = Guid.NewGuid().ToString();



    }


  }
}