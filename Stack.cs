using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication
{
public class Stack
{
public static void Main(string [] args)
{
stack st = new stack();
while (true)
{
System.Console.Clear();
System.Console.WriteLine("\nStack MENU(size -- 10)");
System.Console.WriteLine("1. Add an element");
System.Console.WriteLine("2. See the Top element.");
System.Console.WriteLine("3. Remove top element.");
System.Console.WriteLine("4. Display stack elements.");
System.Console.WriteLine("5. Exit");
System.Console.Write("Select your choice: ");
int choice = Convert.ToInt32(System.Console.ReadLine());
switch (choice)
{
case 1:
System.Console.WriteLine("Enter an Element : ");
st.Push(Console.ReadLine());
break;
case 2:
System.Console.WriteLine("Top element is: {0}", st.Peek());
break;
case 3:
System.Console.WriteLine("Element removed: {0}", st.Pop());
break;
case 4:
st.Display();
break;
case 5:
System.Environment.Exit(1);
break;
}
System.Console.ReadKey();
}
}
}
public interface StackADT
{
 Boolean isEmpty();
 void Push(Object element);
 Object Pop();
 Object Peek();
 void Display();
}
public class stack : StackADT
{
private int StackSize;
public int StackSizeSet
{
get { return StackSize; }
set { StackSize = value; }
}
public int top;
public Object[] item;
public stack()
{
StackSizeSet = 10;
item = new Object[StackSizeSet];
top = -1;
}
public stack(int capacity)
{
StackSizeSet = capacity;
item = new Object[StackSizeSet];
top = -1;
}
public bool isEmpty()
{
if (top == -1) return true;
return false;
}
public void Push(object element)
{
if (top == (StackSize - 1))
{
System.Console.WriteLine("Stack is full!");
}
else
{
item[++top] = element;
System.Console.WriteLine("Item pushed successfully!");
}
}
public object Pop()
{
if (isEmpty())
{
System.Console.WriteLine("Stack is empty!");
return "No elements";
}
else
{
return item[top--];
}
}
public object Peek()
{
if (isEmpty())
{
System.Console.WriteLine("Stack is empty!");
return "No elements";
}
else
{
return item[top];
}
}
public void Display()
{
for (int i = top; i > -1; i--)
{
System.Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
}
}
}
}