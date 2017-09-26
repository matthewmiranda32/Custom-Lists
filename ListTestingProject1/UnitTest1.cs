using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListTestingProject1
{
    //[TestClass]
    //public class UnitTest1
    //{
    //    [TestMethod]
    //    public void AppendFibonacciList()
    //    {
    //        //Arrange
    //        CustomList<int> number = new CustomList<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
    //        int toAdd = 34;

    //        //Act
    //        number.Add(toAdd);

    //        //Assert
    //        Assert.AreEqual(toAdd, number[8]);
    //    }
    //    [TestMethod]
    //    public void CheckFibonacciIndex()
    //    {
    //        //Arrange
    //        CustomList<int> number = new CustomList<int> { 1, 1, 2, 3, 5, 8, 13, 21 };
    //        int listCharacter = 1;

    //        //Act
    //        number.Add(3);

    //        //Assert
    //        Assert.AreEqual(listCharacter, number[0]);
    //    }
    //    [TestMethod]
    //    public void Add_ToFibonacciIndex()
    //    {
    //        //Arrange
    //        CustomList<int> number = new CustomList<int> { 1, 1, 2, 3, 5, 8, 13, 21, 16, 18, 19, 3, 4, 5, 6 };
    //        int expected = 5;

    //        //Act
    //        number.Add(4);

    //        //Assert
    //        Assert.AreEqual(expected, number[0]);
    //    }
    //    [TestMethod]
    //    public void FindSecondToLast()
    //    {
    //        //Arrange
    //        CustomList<int> number = new CustomList<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
    //        int secondToLastNumber = 34;

    //        //Act
    //        number.Add(9);

    //        //Assert
    //        Assert.AreEqual(secondToLastNumber, number[8]);
    //    }
    //    [TestMethod]
    //    public void AddTwoNumbers()
    //    {
    //        //Arrange
    //        CustomList<int> number = new CustomList<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
    //        int first = 55;
    //        int second = 89;

    //        //Act
    //        number.Add(first);
    //        number.Add(second);

    //        //Arrange
    //        Assert.AreEqual(second, number[10]);
    //    }
        //    [TestMethod]
        //    public void CheckIfRemoved()
        //    {
        //        //Arrange
        //        CustomList<int> number = new CustomList<int> { 1, 1, 2, 3, 5, 8, 13, 21, 42 };
        //        int removeNumber = 1;

        //        //Act
        //        number.Remove(42);

        //        //Assert
        //        Assert.AreEqual(removeNumber, number[1]);
        //    }
        //    [TestMethod]
        //    public void Remove_CheckIfRemoved()
        //    {
        //        //Arrange
        //        CustomList<int> number = new CustomList<int> { 1, 1, 2, 3, 5, 8, 13, 21, 42 };
        //        bool expected = false;
        //        //Act
        //        number.Remove(42);
        //        foreach (var item in number)
        //        {
        //            if (item == 42)
        //            {
        //                expected = true;
        //            }
        //        }
        //        //Assert
        //        Assert.IsFalse(expected);
        //    }
        //    [TestMethod]
        //    public void AddThenRemove()
        //    {
        //        //Arrange
        //        CustomList<int> number = new CustomList<int>();
        //        int factor = 53;
        //        int factor2 = 43;

        //        //Act
        //        number.Add(factor);
        //        number.Add(factor2);
        //        number.Remove(factor);

        //        //Arrange
        //        Assert.AreEqual(factor2, number[0]);
        //    }
        //    [TestMethod]
        //    public void CheckNumberAtIndex()
        //    {
        //        //Arrange
        //        CustomList<int> number = new CustomList<int> { 2, 3, 5, 7, 11, 13, 15, 17, 19 };
        //        int replacementNumber = 17;

        //        //Act
        //        number.Remove(15);

        //        //Arrange
        //        Assert.AreEqual(replacementNumber, number[6]);

        //    }
        //    [TestMethod]
        //    public void RandomAddRemove()
        //    {
        //        //Arrange
        //        CustomList<int> number = new CustomList<int> { 3, 5, 5, 2, 4, 3, 4 };
        //        int fstnumber = 62;
        //        int fstreplacement = 4;
        //        int sndnumber = 33;
        //        int sndreplacement = 55;

        //        //Act
        //        number.Add(fstnumber);
        //        number.Remove(3);
        //        number.Add(fstreplacement);
        //        number.Add(sndnumber);
        //        number.Remove(5);
        //        number.Add(sndreplacement);

        //        //Assert
        //        Assert.AreEqual(fstnumber, number[6]);
        //    }
        //    [TestMethod]
        //    public void ReplaceFirstIndex()
        //    {

        //        //Arrange
        //        CustomList<int> number = new CustomList<int>();
        //        int firstnumber = 45;
        //        int secondnumber = 6;
        //        int thirdnumber = 12;
        //        int fourthnumber = 22;
        //        int firstreplacer = 663;
        //        int secondreplacer = 32;
        //        int thirdreplacer = 43;

        //        //Act
        //        number.Add(firstnumber);
        //        number.Add(secondnumber);
        //        number.Add(thirdnumber);
        //        number.Add(fourthnumber);
        //        number.Remove(6);
        //        number.Add(firstreplacer);
        //        number.Remove(12);
        //        number.Add(secondreplacer);
        //        number.Remove(663);
        //        number.Remove(45);
        //        number.Add(thirdreplacer);

        //        //Assert
        //        Assert.AreEqual(fourthnumber, number[1]);
        //    }
        //    [TestMethod]
        //    public void IsItStrung()
        //    {
        //        //Arrange
        //        CustomList<int> numbers = new CustomList<int>();
        //        int newnumber1 = 34;
        //        int newnumber2 = 52;
        //        int newnumber3 = 44;
        //        int newnumber4 = 2;
        //        string expected = "4";

        //        //Act
        //        numbers.Add(newnumber1);
        //        numbers.Add(newnumber2);
        //        numbers.Add(newnumber3);
        //        numbers.Add(newnumber4);
        //        string result = numbers.ToString();

        //        //Assert
        //        Assert.AreEqual(expected, result[1]);
        //    }
        //    [TestMethod]
        //    public void PullStringCharacter()
        //    {
        //        //Arrange
        //        CustomList<int> numbers = new CustomList<int>();
        //        int listPiece = 4;
        //        int listPiece2 = 3;
        //        int listPiece3 = 5;
        //        int listPiece4 = 0;
        //        int listPiece5 = 7;

        //        //Act
        //        numbers.Add(listPiece);
        //        numbers.Add(listPiece2);
        //        numbers.Add(listPiece3);
        //        numbers.Add(listPiece4);
        //        numbers.Add(listPiece5);
        //        string result = numbers.ToString();

        //        //Assert
        //        Assert.AreEqual("43507", result);
        //    }
        //    [TestMethod]
        //    public void ReplacedStringCharacters()
        //    {
        //        //Arrange
        //        CustomList<int> numbers = new CustomList<int>();
        //        int listObject1 = 35;
        //        int listObject2 = 94;
        //        int listObject3 = 21;
        //        int listObject4 = 21;
        //        int replacementObject1 = 21;
        //        int replacementObject2 = 21;
        //        string expected = "21212121";
        //        //Act
        //        numbers.Add(listObject1);
        //        numbers.Add(listObject2);
        //        numbers.Add(listObject3);
        //        numbers.Add(listObject4);
        //        numbers.Remove(listObject1);
        //        numbers.Remove(listObject2);
        //        numbers.Add(replacementObject1);
        //        numbers.Add(replacementObject2);
        //        string result = numbers.ToString();

        //        //Assert
        //        Assert.AreEqual(expected, result);
        //    }
        //    [TestMethod]
        //    public void CountTest()
        //    {
        //        //Arrange
        //        CustomList<int> numbers = new CustomList<int> { 3, 3, 2, 3, 2, 3 };

        //        //Act
        //        numbers.Remove(2);
        //        numbers.Remove(3);


        //        //Assert
        //        Assert.AreEqual(4, numbers.Count);
        //    }
        //    [TestMethod]
        //    public void FindLastCharacter()
        //    {
        //        //Arrange
        //        CustomList<int> numbers = new CustomList<int> { 6, 7, 2222, 221, 4, 0, 11 };
        //        string expected = "67011";
        //        //Act
        //        numbers.Remove(2222);
        //        numbers.Remove(221);
        //        numbers.Remove(4);
        //        string result = numbers.ToString();

        //        //Assert
        //        Assert.AreEqual(result, expected);
        //    }
        //    [TestMethod]
        //    public void AddingLists()
        //    {
        //        //Arrange
        //        CustomList<int> numbers = new CustomList<int> { 11, 5, 5, 48, 87, 2, 88, 7, 2 };
        //        CustomList<int> numbers2 = new CustomList<int> { 12, 31, 54, 2, 2, 3, 33, 2, 2 };

        //        //Act
        //        CustomList<int> addition = numbers + numbers2;

        //        //Assert
        //        Assert.AreEqual(18, addition.Count);
        //    }
        //    [TestMethod]
        //    public void AddingStringNumbers()
        //    {
        //        //Arrange
        //        CustomList<int> one = new CustomList<int>();
        //        CustomList<int> two = new CustomList<int>();
        //        CustomList<int> three = new CustomList<int> { 57, 21, 8, 30, 29 };

        //        int numberToAdd = 57;
        //        int numberToAdd1 = 21;
        //        int numberToAdd2 = 8;
        //        int numberToAdd3 = 30;
        //        int numberToAdd4 = 29;

        //        //Act
        //        one.Add(numberToAdd);
        //        one.Add(numberToAdd1);
        //        one.Add(numberToAdd2);
        //        two.Add(numberToAdd3);
        //        two.Add(numberToAdd4);

        //        CustomList<int> result = one + two;

        //        //Assert
        //        Assert.AreEqual(three, result);
        //    }
        //    [TestMethod]
        //    public void RemovedNumberString()
        //    {
        //        //Arrange
        //        CustomList<int> integers = new CustomList<int> { 57, 41, 32, 23, 8 };
        //        CustomList<int> moreIntegers = new CustomList<int> { 35, 69, 3, 99, 5 };
        //        int expected = 41;
        //        //Act
        //        integers.Remove(32);
        //        moreIntegers.Remove(35);
        //        moreIntegers.Remove(69);

        //        CustomList<int> combinedLists = integers + moreIntegers;

        //        //Assert
        //        Assert.AreEqual(expected, combinedLists[1]);
        //    }
        //    [TestMethod]
        //    public void CompareListCounts()
        //    {
        //        //Arrange
        //        CustomList<int> newNumberList = new CustomList<int> { 658, 512, 89, 21, 4 };
        //        CustomList<int> secondNumberList = new CustomList<int> { 65, 88, 558, 34, 2 };
        //        int expectedListCount = 10;
        //        //Act
        //        newNumberList.Remove(658);
        //        newNumberList.Remove(512);
        //        newNumberList.Add(67);
        //        secondNumberList.Add(55);
        //        secondNumberList.Add(44);
        //        secondNumberList.Remove(558);

        //        CustomList<int> revisedNumberList = newNumberList + secondNumberList;

        //        //Assert
        //        Assert.AreEqual(expectedListCount, revisedNumberList.Count);
        //    }
        //    [TestMethod]
        //    public void RemoveFromCombinedList()
        //    {
        //        //Arrange
        //        CustomList<int> numbersInAList = new CustomList<int> { 32, 34, 35, 42, 32 };
        //        CustomList<int> morenumbersInAList = new CustomList<int> { 23, 32, 40, 34, 12 };
        //        string combinedLists = "323435423232403412";
        //        //Act
        //        CustomList<int> combinedList = numbersInAList + morenumbersInAList;
        //        combinedList.Remove(23);
        //        string newList = combinedList.ToString();

        //        //Assert
        //        Assert.AreEqual(combinedList, newList);
        //    }
        //    [TestMethod]
        //    public void SubtractTwoLists()
        //    {
        //        //Arrange
        //        CustomList<int> firstList = new CustomList<int> { 32, 42, 14, 5, 9 };
        //        CustomList<int> secondList = new CustomList<int> { 32, 14, 5 };
        //        int listDifferenceCount = 2;
        //        //Act
        //        CustomList<int> listDifference = firstList - secondList;

        //        //Assert
        //        Assert.AreEqual(listDifferenceCount, listDifference.Count;);
        //    }
        //    [TestMethod]
        //    public void RemoveAndSubtract()
        //    {
        //        //Arrange
        //        CustomList<int> firstList = new CustomList<int> { 43, 21, 25, 55, 23 };
        //        CustomList<int> secondList = new CustomList<int> { 21, 55, 23 };
        //        CustomList<int> expectedDifferece = new CustomList<int> { 43, 25 };

        //        //Act
        //        secondList.Remove(53);
        //        CustomList<int> listDifference = firstList - secondList;

        //        //Assert
        //        Assert.AreEqual(expectedDifferece, listDifference);
        //    }
        //    [TestMethod]
        //    public void AddAndSubtract()
        //    {
        //        //Arrange
        //        CustomList<int> firstList = new CustomList<int>();
        //        CustomList<int> secondList = new CustomList<int>();
        //        int firstListInt1 = 42;
        //        int firstListInt2 = 43;
        //        int firstListInt3 = 44;
        //        int firstListInt4 = 45;
        //        int firstListInt5 = 46;
        //        int secondListInt1 = 44;
        //        int secondListInt2 = 46;

        //        //Act
        //        firstList.Add(firstListInt1);
        //        firstList.Add(firstListInt2);
        //        firstList.Add(firstListInt3);
        //        firstList.Add(firstListInt4);
        //        firstList.Add(firstListInt5);
        //        secondList.Add(secondListInt1);
        //        secondList.Add(secondListInt2);
        //        CustomList<int> thirdList = firstList - secondList;

        //        //Assert
        //        Assert.AreEqual(firstList[3], thirdList[2]);
        //    }
        //    [TestMethod]
        //    public void SubtractAndString()
        //    {
        //        //Arrange
        //        CustomList<int> newNumberList = new CustomList<int> { 7, 14, 21, 28, 35, 42, 49 }
        //        CustomList<int> scndNumberList = new CustomList<int> { 35, 42, 49 }

        //        //Act
        //        CustomList<int> redoneList = newNumberList - scndNumberList;
        //        string result = redoneList.ToString();

        //        //Assert
        //        Assert.AreEqual(newNumberList[2], result[5] + result[6]);
        //    }
        //    [TestMethod]

        //    public void AddAndSubtractLists()
        //    {
        //        //Arrange
        //        CustomList<int> fstNumberList = new CustomList<int> { 2, 4, 6, 8, 10 };
        //        CustomList<int> scndNumberList = new CustomList<int> { 12, 14, 16, 18 };
        //        CustomList<int> thrdNumberList = new CustomList<int> { 2, 6, 10, 14, 18 };

        //        //Act
        //        CustomList<int> combinedLists = fstNumberList + scndNumberList;
        //        CustomList<int> subtractedLists = combinedLists - thrdNumberList;

        //        //Assert
        //        Assert.AreEqual(scndNumberList[2], subtractedLists[3]);
        //    }
        //}
    }
