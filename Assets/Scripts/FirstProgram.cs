using System;
using System.Collections.Generic;
using UnityEngine;

public class FirstProgram : MonoBehaviour
{
    struct MyStruct
    {
        public int X;
        public int Y;
    }

    void Start()
    {
        #region ������� 1

        /*1. �������� ���������� ��������� ����� ������:
         * int, float, bool, string. 
         * �������� �� myInt, myFloat, myBool, myString ��������������.
         * ����� �������� ��������� � ���� �� ������ ������ � 
         * �������� �� myConstInt, myConstFloat, myConstBool, myConstString.
         * �������� ������������ � ������������� ����������� ����� � ����� �����������.
        */

        // ������������ �����������
        int myInt = 10; // ���������� ���������� ���� int
        float myFloat = 20.5f; // ���������� ���������� ���� float
        bool myBool = true; // ���������� ���������� ���� bool
        string myString = "Hello, Worl�d!"; // ���������� ���������� ���� string
        
        /* ������������� �����������
           ���������� �������� 
        */

        const int myConstInt = 100;
        const float myConstFloat = 200.5f;
        const bool myConstBool = false;
        const string myConstString = "Hello, Universe!";

        Debug.Log(myConstString);
        Debug.Log(myFloat);

        #region �����
        /*
        // ������������ �����������
        int myInt = 10; // ���������� ���������� ���� int
        float myFloat = 20.5f; // ���������� ���������� ���� float
        bool myBool = true; // ���������� ���������� ���� bool
        string myString = "Hello, World!"; // ���������� ���������� ���� string
        */
        /* ������������� �����������
           ���������� �������� 
        const int myConstInt = 100;
        const float myConstFloat = 200.5f;
        const bool myConstBool = false;
        const string myConstString = "Hello, Universe!";
        */

        #endregion

        #endregion

        #region ������� 2

        /*2. ����������� ��������� ���������� � ��������� +, -.
         * ��������� �������� ���������� myInt � myConstInt. ��������� ��������� � ���������� ���� int, �� ����� resultInt.
         * ��������� ��������� ���������� myConstFloat �� ���������� myFloat. ��������� ��������� � ���������� ���� float, �� ����� resultFloat.
         * ��������� �������� (������������) ��������� ���������� myString � myConstString. ��������� ��������� � ���������� ���� string, �� ����� resultString.
        */

        #region �����
        
        int resultInt = myInt + myConstInt; // �������� int
        float resultFloat = myFloat - myConstFloat; // ��������� float
        string resultString = myString + " " + myConstString; // ������������ �����
      
        Debug.Log (resultString);

        #endregion

        #endregion

        #region ������� 3

        /*3. ����������� �������������� ������� Math.Sqrt �� ���������� myInt. ��������� ��������� � ���������� ���� double ��� ��������� sqrtResult.
         * ����������� �������������� ������� Math.Pow �� ���������� myFloat, ��������� myFloat �� ������ �������. ��������� ��������� � ���������� ���� double ��� ��������� powResult.
        */

        #region �����
        double sqrtResult = Math.Sqrt(myInt); // ������ ����������
        double powResult = Math.Pow(myFloat, 2); // ���������� � �������

        Debug.Log(sqrtResult);
        Debug.Log(Math.Sqrt(9));

        #endregion

        #endregion

        #region ������� 4

        /*4. ����������� ����� � ������� �������������� ����� ������ � ������� �������� � �������.
         * �������� ���������� ���� double ��� ��������� myDouble � �������� ������� �������������� ���������� myInt. �������� � ������� ���������.
         * �������� ���������� ���� int ��� ��������� myNewInt � �������� ����� �������������� ���������� myFloat � ���� int. �������� � ������� ���������.
        */

        #region �����
        
        // ������� ��������������
        double myDouble = myInt;
        Debug.Log(myDouble);

        // ����� ��������������
        int myNewInt = (int)myFloat;
        Debug.Log(myNewInt);
        
        #endregion

        #endregion

        #region ������� 5

        //5. �������� ������ ��� ������ myArray � � ����� ������ string, ��������������� ��� ����� ����������� ��������� ������. ����������� �������� ������� ��� ������ � �������.

        #region �����

        string[] myArray = new string[3] {"One", "Two", "Three"};
        Debug.Log(myArray[0]);
        Debug.Log(myArray[1]);
        Debug.Log(myArray[2]);

        #endregion

        #endregion

        #region ������� 6

        /*6. �������� ���� ��� ������ myList � ����� ������ int, �������� � ���� ����� 1, 2, 3, ��������� ������ Add. 
         * �������� � ������� �������� ��������� ������. 
         * ������� ����� �������� ��������� ������� Remove, RemoveAt.
        */

        #region �����
        List<int> myList = new List<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        Debug.Log(myList[0]);
        Debug.Log(myList[1]);
        Debug.Log(myList[2]);
        myList.Remove(2);
        myList.RemoveAt(0);
        Debug.Log(myList[0]);

        #endregion

        #endregion

        #region ������� 7

        /*7. �������� ��������� ��� ������ MyStruct. �������� � ��������� ���������� ���� int ��� ������ X � ������ Y.
         * �������� ���������� � ����� ��������� MyStruct � ������ myStruct.
         * ������������������ ���������� myStruct, ������� �������� ���������� X � Y.
         * �������� � ������� �������� ���������� X � Y �� ��������� myStruct.
        */

        #region �����

        

        MyStruct myStruct;
        myStruct.X = 17;
        myStruct.Y = myInt + myConstInt;
        Debug.Log(myStruct.X);
        Debug.Log(myStruct.Y);

        #endregion

        #endregion

        #region ������� 8

        //8. �������� ������� � ������� ����������, ������ �� �������� ���������� myInt ��� 0. ����������� if else � �������� � ������� ������ ������.

        #region �����

        bool condition = true;

        if (myInt > 0 && condition)
        {
            Debug.Log("myInt is positive.");
        }
        else
        {
            Debug.Log("myInt is not positive.");
        }

        #endregion

        #endregion

        #region ������� 9

        //9. ����������� switch ��� �������� ��� ��������� � ���������� myString. ����������� ��������� case � default. �������� � ������� ������ ������.

        #region �����

        switch (myString)
        {
            case "Hello, World!":
                Debug.Log("Greeting the world.");
                break;
            case "Hello, Universe!":
                Debug.Log("Greeting the universe.");
                break;
            case "Hello, Universe!2":
                Debug.Log("Greeting the universe.");
                break;
            case "Hello, Universe!3":
                Debug.Log("Greeting the universe.");
                break;
            default:
                Debug.Log("Unknown greeting.");
                break;
        }

        #endregion

        #endregion

        #region ������� 10

        /* 10. ����������� ���� for ��� ������ ���� �������� ������� myArray.
         * ����������� ���� while ��� �������� ���� ��������� ������ myList � ������� ������ RemoveAt(0).
         * ���������� �������� ���������� myInt ������ 10. ����������� ���� do while ��� ���� ����� ������� �������� ���������� myInt �� 0. �������� �� ������ ���� � ������� �������� myInt. 
        */

        #region �����

        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log(myArray[i]); // ����� ��������� ������� 
        }
        while (myList.Count > 0)
        {
            Debug.Log(myList[0]); // ����� ������� �������� ������ 
            myList.RemoveAt(0); // �������� ������� �������� ������ 
        }

        myInt = 2;
        do
        {
            Debug.Log(myInt); // ����� �������� myInt 
            myInt--; // ���������� �������� myInt �� 1 
        } while (myInt > 0);

        #endregion

        #endregion

        #region ������� 11

        //11. �������� ������� ��� ������������� �������� � ��� ���������� � ������ MyFunction. �������� � ���� ���� ������� ����� ���������� � �������. �������� ��� ������� �� ������ �����.

        #region �����

        void MyFunction()
        {
            Debug.Log("This is my function."); // ����� ��������� 
        }
        MyFunction(); // ����� ������� 

        #endregion

        #endregion

        #region ������� 12

        //12. �������� ������� ��� ������������� �������� � ����������� � ������ MyFunctionWithParameters. ��������� �������� param1 � param2. param1 ��� ������������� ���, � param2 - ���������. �������� � ������� �������� ���������� � ���� ���� �������. �������� ��� ������� �� ������ �����.

        #region �����

        void MyFunctionWithParameters(int param1, string param2)
        {
            Debug.Log("This is my function with parameters: " + param1 + ", " + param2); // ����� ��������� � ����������� 
        }
        MyFunctionWithParameters(myInt, myString); // ����� ������� � �����������

        #endregion

        #endregion

        #region ������� 13
        //13. �������� ������� � ������������ ��������� � ����������� � ������ MyFunctionWithReturnValueAndParameters. ��������� �������� param1 � param2. ��� ��������� �������������. ������� � ������� return ����� ���� ����������.

        #region �����

        Debug.Log(myInt);
        Debug.Log(myConstInt);

        int MyFunctionWithReturnValueAndParameters(int param1, int param2)
        {
            return param1 + param2; // ������� ����� ���������� 
        }
        int result = MyFunctionWithReturnValueAndParameters(myInt, myConstInt); // ����� ������� � ����������� � ���������� ���������� 
        Debug.Log(result); // ����� ����������

        #endregion
        #endregion

        GetComponent<Rigidbody>().AddForce(Vector3.up * 20, ForceMode.VelocityChange);
    }
}