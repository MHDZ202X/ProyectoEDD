/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Milton
 */
public class Principal 
{
 public static void main(String[] args) 
 {
  Cola cola1=new Cola();
  cola1.insertar(46);
  cola1.insertar(12);
  cola1.insertar(87);
  cola1.insertar(125);
  cola1.insertar(30);
  cola1.extraer();
  cola1.estaVacia();
  cola1.contar();
  System.out.println(cola1.toString());
 }
}