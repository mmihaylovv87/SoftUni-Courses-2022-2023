using System;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    private HeroRepository heroRepository;

    [SetUp]
    public void SetUp()
    {
        this.heroRepository = new HeroRepository();
    }

    [Test]
    public void ConstructorShouldInitializeRequiredValues()
    {
        HeroRepository heroRepository = new HeroRepository();

        Assert.IsNotNull(heroRepository.Heroes);
    }

    [Test]
    public void CreateMethodShouldThrowAnExceptionForNull()
    {
        Assert.Throws<ArgumentNullException>(() => heroRepository.Create(null));
    }

    [Test]
    public void CreateMethodShouldThrowAnExceptionForDuplicateHeroes()
    {
        Hero hero = new Hero("Georgi", 50);

        heroRepository.Create(hero);

        Assert.Throws<InvalidOperationException>(() => heroRepository.Create(hero));
    }

    [Test]
    public void CreateMethodShouldCreateHeroWithValidData()
    {
        Hero hero = new Hero("Georgi", 50);

        var message = heroRepository.Create(hero);
        var expectedMessage = "Successfully added hero Georgi with level 50";

        Assert.AreEqual(1, heroRepository.Heroes.Count);
        Assert.AreEqual(expectedMessage, message);
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void RemoveMethodShouldThrowAnExceptionForNullOrWhiteSpace(string name)
    {
        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(name));
    }

    [Test]
    public void RemoveMethodShouldRemoveHeroWithValidData()
    {
        Hero hero = new Hero("Georgi", 50);
        heroRepository.Create(hero);

        var isRemoved = heroRepository.Remove("Georgi");

        Assert.IsTrue(isRemoved);
        Assert.AreEqual(0, heroRepository.Heroes.Count);
    }

    [Test]
    public void RemoveMethodShouldRemoveHeroWithMissingData()
    {
        var isRemoved = heroRepository.Remove("Georgi");

        Assert.IsFalse(isRemoved);
        Assert.AreEqual(0, heroRepository.Heroes.Count);
    }

    [Test]
    public void GetHeroWithHighestLevelSuccess()
    {
        Hero georgi = new Hero("Georgi", 50);
        Hero niki = new Hero("Niki", 100);
        Hero viktor = new Hero("Viktor", 90);

        heroRepository.Create(georgi);
        heroRepository.Create(niki);
        heroRepository.Create(viktor);

        var hero = heroRepository.GetHeroWithHighestLevel();

        Assert.AreSame(niki, hero);
    }

    [Test]
    public void GetHeroShouldReturnHero()
    {
        Hero georgi = new Hero("Georgi", 50);
        Hero niki = new Hero("Niki", 100);
        Hero viktor = new Hero("Viktor", 90);

        heroRepository.Create(georgi);
        heroRepository.Create(niki);
        heroRepository.Create(viktor);

        var hero = heroRepository.GetHero("Viktor");

        Assert.AreSame(viktor, hero);
    }
}