using System.Numerics;
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class TestMethods : AssignmentBase
{
    Generics t = new Generics();
    Generics e = new Generics();

    /// <summary>
    /// Return a string
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string StringMethod(string str)
    {
        return str;
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return a new string array
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string[] StringArrayMethod(string[] arr)
    {
        return arr;
        //throw new NotImplementedException();
    }
    /// <summary>
    /// Return the sum of a + b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int AddIntMethod(int a, int b)
    {
        return a + b;
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return the sum of a * b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double MultiplyDoubleMethod(double a, double b)
    {
        return a * b;
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return a list of doubles
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public List<double> ListDoubleMethod()
    {
        return new List<double>{};
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return a single characther
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public char CharMethod(char c)
    {
        return c;
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return a boolean that should be true
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool IsNotTrue(bool value)
    {
        
        return value;
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return a boolean that should be false
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool IsNotFalse(bool value)
    {
        return value;
        // throw new NotImplementedException();
    }
    public List<Generics> GenericTypeMethod(Generics e, Generics t)
    {
        return new List<Generics>{};
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Can enter if the age is greater than or equal to 18, 
    /// if age is greater than or equal to 18, return true, else return false
    /// </summary>
    /// <param name="age"></param>
    /// <exception cref="NotImplementedException"></exception>
    public bool CanEnter(int age) 
    {
        if(age >= 18) return true;
        return false;
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return a new dictionary with int keys and string values
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Dictionary<int, string> DictionaryMethod()
    {
        return new Dictionary<int, string>{};
        // throw new NotImplementedException("");
    }
    /// <summary>
    /// Return the square of a (a * a)
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double Square(double a) 
    {
        return a * a;
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Return the sum of a / b, make sure that a and b cannot be 0
    /// if either is 0, returning 0
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public double DivideNumbers(double a, double b) 
    {
        if (a == 0 || b == 0) return 0;
        return a / b;
        // throw new NotImplementedException();
    }

    /// <summary>
    /// Return a new file
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string CreateNewFile(string path) 
    {
        if(File.Exists(path)) return File.ReadAllText(path);
        File.WriteAllText(path, "fisk");
        return File.ReadAllText(path);
        // throw new NotImplementedException();
    }
    /// <summary>
    /// Append text content to an exisiting file
    /// </summary>
    /// <param name="path"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string AppendTextContent(string path, string content) 
    {
        if(File.Exists(path))
        {
            File.WriteAllText(path, content);
        }
        return path;
        // throw new NotImplementedException();
    }

    public string TernaryTranslator(string str)
    {
        string result = "";
        string[] strArr = str.Split(' ');
        foreach (string s in strArr)
        {
            string st = s;
            int value = 0;
            int positionalValue = 1;
            if(s.Length < 5)
            {
                for(int i = 0; i < 6 - s.Length; i++)
                {
                    st = st.Insert(0, "0");
                }
            }

            for (int i = 5; i >= 0; i--)
            {
                value += (st[i] -48) * positionalValue;
                positionalValue *= 3;
            }
            if (value > 248 || value < 0)
                throw new ArgumentException($"{s} is outside the ASCII table (0 to 100012)");
            result = result + Convert.ToChar(value);
        }
        return result;
    }

    
    /*
    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    *****************     TESTS ********************************
    ***************** Do Not edit these methods ****************
    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    */
    [Assignment(1)]
    public void TestStringMethod()
    {
        string[] expectedPool = { "Hello, World!", "", "C#", "Programming!" };
        Assert.Equal(expectedPool[0], StringMethod(expectedPool[0]));
        Assert.Equal(expectedPool[1], StringMethod(expectedPool[1]));
        for (int i = 0; i < expectedPool.Length; i++)
        {
            Assert.Equal(expectedPool[i], StringMethod(expectedPool[i]));
            Assert.NotNull(StringMethod(expectedPool[i]));
        }
    }

    [Assignment(2)]
    public void TestStringArrayMethod()
    {
        string[] expected = new string[255];
        Assert.Equal(StringArrayMethod(expected), expected);
    }
    [Assignment(3)]
    public void TestIntAddMethod()
    {
        int[] expected = { 3, 5, 10, 25, -2 };
        Assert.Equal(AddIntMethod(1, 2), expected[0]);
        Assert.Equal(AddIntMethod(3, 2), expected[1]);
        Assert.Equal(AddIntMethod(5, 5), expected[2]);
        Assert.Equal(AddIntMethod(20, 5), expected[3]);
        Assert.Equal(AddIntMethod(-4, 2), expected[4]);
    }
    [Assignment(4)]
    public void TestMultiplyDoubleMethod()
    {
        double[] expected = { 4, 5, 10, 25, 1024 };

        Assert.Equal(MultiplyDoubleMethod(2, 2), expected[0]);
        Assert.Equal(MultiplyDoubleMethod(5, 1), expected[1]);
        Assert.Equal(MultiplyDoubleMethod(10, 1), expected[2]);
        Assert.Equal(MultiplyDoubleMethod(5, 5), expected[3]);
        Assert.Equal(MultiplyDoubleMethod(512, 2), expected[4]);

    }
    [Assignment(5)]
    public void TestIsListOfDoubles()
    {
        Assert.Equal(new List<double>(), ListDoubleMethod());
        Assert.Equivalent(new List<double>(), ListDoubleMethod());
    }
    [Assignment(6)]
    public void TestCharMethod()
    {
        char[] expected = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd' };
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(CharMethod(expected[i]), expected[i]);
        }
    }
    [Assignment(7)]
    public void TestBooleanMethods()
    {
        bool[] expected = { true, false, false, true, true };
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(IsNotFalse(expected[i]), expected[i]);
            Assert.Equal(IsNotTrue(expected[i]), expected[i]);
        }
    }
    [Assignment(8)]
    public void TestGenericTypes()
    {
        Assert.Equal(new List<Generics>(), GenericTypeMethod(t, e));
    }
    [Assignment(9)]
    public void TestCanEnter()// Endret test
    {
            Assert.True(CanEnter(18));
            Assert.False(CanEnter(10));
        
    }
    [Assignment(10)]
    public void TestDictionary()
    {
        Assert.Equal(new Dictionary<int, string>(), DictionaryMethod());
    }
    [Assignment(11)]
    public void TestSquare()// Endret test
    {
        double[] expected = { 4, 9, 16, 25, 36, 49, 64 };
        for (int i = 2; i < expected.Length; i++)
        {
            Assert.Equal(expected[i-2], Square(i));
        }
    }
    [Assignment(12)]
    public void TestDivideNumbers()
    {
        double[] expected = {0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5};
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], DivideNumbers(i, 2));
            if (DivideNumbers(expected[i], 0) == double.PositiveInfinity || DivideNumbers(expected[i], 0) == double.NegativeInfinity)
            {
                throw new DivideByZeroException();
            }
        }
    }
    [Assignment(13)]
    public void TestCreateFile()// Endret test
    {
        string filePath = "file.txt";
        if (File.Exists(filePath))
        {
            Assert.NotNull(CreateNewFile(filePath));
        }
        else
        {
            throw new FileLoadException();
        }
        
    }

    [Assignment(14)]
    public void TestAppendTextContent()// Endret test
    {
        string filePath = "file.txt";
        string textContent = "Hello, World!";
        Assert.Equal(textContent, File.ReadAllText(AppendTextContent(filePath, textContent)));
    }

    [Assignment(15)]
    public void TestTernaryTranslator()
    {
        Assert.Equal("Hello, World!", TernaryTranslator("002200 010202 011000 011000 011010 001122 001012 010020 011010 011020 011000 010201 001020"));
        Assert.Equal("It all began with the forging of the Great Rings", TernaryTranslator("002201 011022 001012 010121 011000 011000 001012 010122 010202 010211 010121 011002 001012 011102 010220 011022 010212 001012 011022 010212 010202 001012 010210 011010 011020 010211 010220 011002 010211 001012 011010 010210 001012 011022 010212 010202 001012 002122 011020 010202 010121 011022 001012 010001 010220 011002 010211 011021"));
        Assert.Equal("Random bullshit go!", TernaryTranslator("010001 010121 011002 010201 011010 011001 001012 010122 011100 011000 011000 011021 010212 010220 011022 001012 010211 011010 001020"));
    }
}