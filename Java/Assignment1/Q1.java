package Day1;
import java.util.*;
public class Assignment1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc=new Scanner(System.in);
		System.out.println("Enter the number");
		int num=sc.nextInt();
		int result;
		for(int i=1;i<=10;i++) {
			result=num*i;
		    System.out.println(num+" X "+i+"="+result);
		}
		

	}

}
