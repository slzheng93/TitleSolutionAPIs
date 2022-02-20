using Application_Core.Contracts.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using NUnit.Framework;
using System;
using System.Data.Common;
using System.Threading.Tasks;


namespace TestMovieRepositoryAndService;

public class TestCastRepositoryAndService
{
    private TitlesDbContext _dbContext;
    private Repository _repository;
  

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Setting up Testing Environment");
        string connection =
            "Server=(DESKTOP-VME7NRK\\SQL2019);Database=Titles;Integrated Security=true;";
        _dbContext = new TitlesDbContext(connection);
        _repository = new Repository(_dbContext);
        Console.WriteLine("Testing Environment Setting Succeeded");

    }

    [Test]
    public async Task GetAllTitles()
    {
        var titles = await _repository.GetAllTitle();

        foreach (var item in titles)
        {
            Console.WriteLine(item.TitleName);
        }
    }
}