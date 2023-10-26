package Day1;
import java.util.*;
public class Switch {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num1,num2;
		char c;
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter first number");
		num1=sc.nextInt();		
		System.out.println("Enter second number");
		num2=sc.nextInt();
		c=sc.next().charAt(0);
		switch(c) {
		case('+'):
		System.out.println(num1+num2);
		break;
		case('-'):
		System.out.println(num1-num2);
		break;
		case('/'):
		System.out.println(num1/num2);
		break;
		case('%'):
		System.out.println(num1%num2);
		break;
		case('*'):
		System.out.println(num1*num2);
		break;
		default:
		System.out.println("Enter valid operator");
		
		}

	}
		
			

		

	}
