/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package twiter;

import java.util.LinkedList;
import java.util.Queue;
import java.util.Scanner;

/**
 *
 * @author Avigail Schory
 */
public class Twiter {

    /**
     * @param args the command line arguments
     */
    public static void triangle(int width,int height){
        Scanner in=new Scanner(System.in);
        int choice;
        System.out.println("to see the scope of the triangle enter 1,and to print the triangle enter 2:");
        choice=in.nextInt();
        if(choice==1){
        System.out.println("the scope is: "+((height*2)+width));}
        else if(choice==2){
              if(width%2==0||width*2<height)
                    System.out.println("The triangle cannot be printed");
              else if(width%2==1&&height*2>width){
               printOddTriangle(width,height);
              }
        }
    }
    public static void printOddTriangle(int width,int height){
        int lines,extraLines;
        int groups=width/2-1;
        if(groups!=0)
            lines=(height-2)/groups;
        else lines=1;
        if(groups!=0)
           extraLines=(height-2)%groups;
        else 
            extraLines=1;
        int start=3,h=height;
        Queue<Integer>q=new LinkedList<Integer>();
        q.add(1);
        if(extraLines>0)
        {
           for (int i = 1; i <= extraLines; i++) {
              q.add(start);
              h--;
        }
        }
        while(h-2>0){
            for (int i = 1; i <=lines; i++) {
                q.add(start);
                h--;
            }
            start+=2;
        }
        q.add(width);
        int size=q.size();
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < width-q.peek()/2; j++) {
                System.out.print(" ");
            }
            for (int j = 0; j < q.peek(); j++) {
                System.out.print("*");
            }
            System.out.println("");
            q.remove();
        }
    }

    public static void main(String[] args) {
        Scanner in=new Scanner(System.in);
        int choice,height,width;
        System.out.println("enter your choice please:");
        System.out.println("to rectangle enter 1, to triangular enter 2,to exit enter 3");
        choice=in.nextInt();
        while(choice!=3){
            System.out.println("enter the width of the tower:");
            width=in.nextInt();
            do{
            System.out.println("enter the height of the tower, must be bigger then 2:");
            height=in.nextInt();
            }
            while(height<2);
            if(choice==1){
               if(Math.abs(height-width)>5)
                System.out.println("the area is: "+height*width);
              else
                System.out.println("the scope is: "+((height*2)+(width*2)));
            }
            else if(choice==2){
                triangle(width,height);
              }
        System.out.println("enter your choice please:");
        System.out.println("to rectangle enter 1, to triangular enter 2,to exit enter 3");
        choice=in.nextInt();
        } 
        }
    }
 

