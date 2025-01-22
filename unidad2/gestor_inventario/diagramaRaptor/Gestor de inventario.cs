using System;
using System.IO;
using System.Text;

namespace Gestor de inventario
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? sino;
         ?? encontrado;
         ?? nombre;
         ?? totalproducto;
         ?? i;
         ?? menu;
         ?? inventariolleno;
         ?? inventariovacio;
         ?? opcion;
         ?? totalinventario;
         ??[] preciosi = new ??[??+1];
         ??[] productos = new ??[??+1];
         ??[] cantidades = new ??[??+1];
         ??[] precios = new ??[??+1];
      
         productos[5] = "";
         cantidades[5] = 0;
         precios[5] = 0;
         menu =0;
         inventarioLleno =false;
         InventarioVacio =true;
         Console.WriteLine("Bienvenido al inventario");
         i =0;
         while (1)
         {
            while (1)
            {
               raptor_prompt_variable_zzyz ="¿En que espacio quieres al macenar el producto? (pacacidad 5)";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               i= Double.Parse(Console.ReadLine());
               if (productos(i)=="")) break;
               Console.WriteLine("Ya esta registrado ese producto");
            }
            raptor_prompt_variable_zzyz ="Ingresa el nombre del producto: ";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            nombre= Double.Parse(Console.ReadLine());
            productos[i] = nombre;
            raptor_prompt_variable_zzyz ="Ingresa el precio unitario de "+productos(i)+":";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            precios(i)= Double.Parse(Console.ReadLine());
            raptor_prompt_variable_zzyz ="Ingresa la cantidad de "+productos(i)+":";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            cantidades(i)= Double.Parse(Console.ReadLine());
            InventarioVacio =false;
            Console.WriteLine(productos(i)+" agregado al inventario");
            if (productos(1)!="" && productos(2)!="" && productos(3)!="" && productos(4)!="" && productos(5)!="")
            {
               Console.WriteLine("Inventario lleno, elimine un producto para agregar uno nuevo");
               inventarioLleno =true;
               siNo =2;
            }
            else
            {
               raptor_prompt_variable_zzyz ="¿Desea agregar otro producto?:  1.- si   2.- no";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               siNo= Double.Parse(Console.ReadLine());
            }
            while (!(siNo==1 || siNo==2))
            {
               raptor_prompt_variable_zzyz ="Opcion invalida.";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               siNo= Double.Parse(Console.ReadLine());
            }
            if (siNo==2)) break;
         }
         if (inventarioLleno==true)
         {
            raptor_prompt_variable_zzyz ="Ingrese el número de opción:  2.- Modificar   3.-Consultar   4 .- Salir  5.- Eliminar";
            Console.WriteLine(raptor_prompt_variable_zzyz);
            menu= Double.Parse(Console.ReadLine());
            while (!(menu>1 && menu<6))
            {
               raptor_prompt_variable_zzyz ="Opción invalida, seleccione una opcion correcta ";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               menu= Double.Parse(Console.ReadLine());
            }
         }
         else
         {
            if (InventarioVacio==true)
            {
               raptor_prompt_variable_zzyz ="Ingrese el número de opción: 1.- Agregar  2.- Modificar   3.-Consultar   4 .- Salir";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               menu= Double.Parse(Console.ReadLine());
               while (!(menu>0 && menu<5))
               {
                  raptor_prompt_variable_zzyz ="Opción invalida, seleccione una opcion correcta ";
                  Console.WriteLine(raptor_prompt_variable_zzyz);
                  menu= Double.Parse(Console.ReadLine());
               }
            }
            else
            {
               raptor_prompt_variable_zzyz ="Ingrese el número de opción: 1.- Agregar  2.- Modificar   3.-Consultar   4 .- Salir  5.- Eliminar";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               menu= Double.Parse(Console.ReadLine());
               while (!(menu>0 && menu<6))
               {
                  raptor_prompt_variable_zzyz ="Opción invalida, seleccione una opcion correcta ";
                  Console.WriteLine(raptor_prompt_variable_zzyz);
                  menu= Double.Parse(Console.ReadLine());
               }
            }
         }
         while (1)
         {
            if (menu==1)
            {
               i =0;
               while (1)
               {
                  while (1)
                  {
                     raptor_prompt_variable_zzyz ="¿En que espacio quieres al macenar el producto? (pacacidad 5)";
                     Console.WriteLine(raptor_prompt_variable_zzyz);
                     i= Double.Parse(Console.ReadLine());
                     if (productos(i)=="")) break;
                     Console.WriteLine("Ya esta registrado ese producto");
                  }
                  raptor_prompt_variable_zzyz ="Ingresa el nombre del producto: ";
                  Console.WriteLine(raptor_prompt_variable_zzyz);
                  nombre= Double.Parse(Console.ReadLine());
                  productos[i] = nombre;
                  raptor_prompt_variable_zzyz ="Ingresa el precio unitario de "+productos(i)+":";
                  Console.WriteLine(raptor_prompt_variable_zzyz);
                  precios(i)= Double.Parse(Console.ReadLine());
                  raptor_prompt_variable_zzyz ="Ingresa la cantidad de "+productos(i)+":";
                  Console.WriteLine(raptor_prompt_variable_zzyz);
                  cantidades(i)= Double.Parse(Console.ReadLine());
                  InventarioVacio =false;
                  Console.WriteLine(productos(i)+" agregado al inventario");
                  if (productos(1)!="" && productos(2)!="" && productos(3)!="" && productos(4)!="" && productos(5)!="")
                  {
                     Console.WriteLine("Inventario lleno, elimine un producto para agregar uno nuevo");
                     inventarioLleno =true;
                     siNo =2;
                  }
                  else
                  {
                     raptor_prompt_variable_zzyz ="¿Desea agregar otro producto?:  1.- si   2.- no";
                     Console.WriteLine(raptor_prompt_variable_zzyz);
                     siNo= Double.Parse(Console.ReadLine());
                  }
                  while (!(siNo==1 || siNo==2))
                  {
                     raptor_prompt_variable_zzyz ="Opcion invalida.";
                     Console.WriteLine(raptor_prompt_variable_zzyz);
                     siNo= Double.Parse(Console.ReadLine());
                  }
                  if (siNo==2)) break;
               }
            }
            else
            {
               if (menu==2)
               {
                  while (1)
                  {
                     encontrado =false;
                     while (1)
                     {
                        nombre ="";
                        raptor_prompt_variable_zzyz ="Escribe el nombre del producto:";
                        Console.WriteLine(raptor_prompt_variable_zzyz);
                        nombre= Double.Parse(Console.ReadLine());
                        i =1;
                        while (1)
                        {
                           if (productos(i)==nombre)
                           {
                              encontrado =true;
                           }
                           else
                           {
                              i =i+1;
                           }
                           if (i>5 || encontrado==true)) break;
                        }
                        if (encontrado==true)
                        {
                           siNo =2;
                        }
                        else
                        {
                           raptor_prompt_variable_zzyz ="No se encontro el producto. ¿Deseas internar de nuevo?:  1.- si  2.- no";
                           Console.WriteLine(raptor_prompt_variable_zzyz);
                           siNo= Double.Parse(Console.ReadLine());
                        }
                        while (!(siNo==1 || siNo==2))
                        {
                           raptor_prompt_variable_zzyz ="Opcion invalida.";
                           Console.WriteLine(raptor_prompt_variable_zzyz);
                           siNo= Double.Parse(Console.ReadLine());
                        }
                        if (siNo==2)) break;
                     }
                     if (encontrado==true)
                     {
                        while (1)
                        {
                           opcion =0;
                           raptor_prompt_variable_zzyz ="¿Desea cambiar el precio o la cantidad de "+productos(i)+" ?: 1.- precio    2.- cantidad";
                           Console.WriteLine(raptor_prompt_variable_zzyz);
                           opcion= Double.Parse(Console.ReadLine());
                           if (opcion==1 || opcion==2)) break;
                           Console.WriteLine("Opción invalida");
                        }
                        if (opcion==1)
                        {
                           raptor_prompt_variable_zzyz ="Ingresa el precio unitario de "+productos(i)+":";
                           Console.WriteLine(raptor_prompt_variable_zzyz);
                           preciosi(i)= Double.Parse(Console.ReadLine());
                        }
                        else
                        {
                           if (opcion==2)
                           {
                              raptor_prompt_variable_zzyz ="Ingresa la cantidad de "+productos(i)+":";
                              Console.WriteLine(raptor_prompt_variable_zzyz);
                              cantidades(i)= Double.Parse(Console.ReadLine());
                           }
                           else
                           {
                           }
                        }
                        Console.WriteLine(productos(i)+" actualizado.");
                     }
                     else
                     {
                        Console.WriteLine("Producto no encontrado");
                     }
                     raptor_prompt_variable_zzyz ="¿Desea modificar otro producto?: 1.- si    2.- no";
                     Console.WriteLine(raptor_prompt_variable_zzyz);
                     siNo= Double.Parse(Console.ReadLine());
                     while (!(siNo==1 || siNo==2))
                     {
                        raptor_prompt_variable_zzyz ="Opcion invalida.";
                        Console.WriteLine(raptor_prompt_variable_zzyz);
                        siNo= Double.Parse(Console.ReadLine());
                     }
                     if (siNo==2)) break;
                  }
               }
               else
               {
                  if (menu==3)
                  {
                     totalInventario =0;
                     i =1;
                     while (1)
                     {
                        if (productos(i)!="")
                        {
                           totalProducto =0;
                           Console.WriteLine(productos(i));
                           Console.WriteLine("precio: "+precios(i));
                           Console.WriteLine("cantidad: "+cantidades(i));
                           totalProducto =precios(i)*cantidades(i);
                           totalInventario =totalInventario+totalProducto;
                           Console.WriteLine("Valor total de "+productos(1)+": "+totalProducto);
                           totalProducto =0;
                        }
                        else
                        {
                        }
                        if (i==5)) break;
                        i =i+1;
                     }
                     Console.WriteLine("Valor total del inventario: "+totalInventario);
                  }
                  else
                  {
                     if (menu==5)
                     {
                        while (1)
                        {
                           encontrado =false;
                           while (1)
                           {
                              nombre ="";
                              raptor_prompt_variable_zzyz ="Escribe el nombre del producto:";
                              Console.WriteLine(raptor_prompt_variable_zzyz);
                              nombre= Double.Parse(Console.ReadLine());
                              i =1;
                              while (1)
                              {
                                 if (productos(i)==nombre)
                                 {
                                    encontrado =true;
                                 }
                                 else
                                 {
                                    i =i+1;
                                 }
                                 if (i>5 || encontrado==true)) break;
                              }
                              if (encontrado==true)
                              {
                                 siNo =2;
                              }
                              else
                              {
                                 raptor_prompt_variable_zzyz ="No se encontro el producto. ¿Deseas internar de nuevo?:  1.- si  2.- no";
                                 Console.WriteLine(raptor_prompt_variable_zzyz);
                                 siNo= Double.Parse(Console.ReadLine());
                              }
                              while (!(siNo==1 || siNo==2))
                              {
                                 raptor_prompt_variable_zzyz ="Opcion invalida.";
                                 Console.WriteLine(raptor_prompt_variable_zzyz);
                                 siNo= Double.Parse(Console.ReadLine());
                              }
                              if (siNo==2)) break;
                           }
                           if (encontrado==true)
                           {
                              raptor_prompt_variable_zzyz ="¿Deseas eliminar a "+productos(i)+"?: 1.- si    2.- no";
                              Console.WriteLine(raptor_prompt_variable_zzyz);
                              siNo= Double.Parse(Console.ReadLine());
                              while (!(siNo==1 || siNo==2))
                              {
                                 raptor_prompt_variable_zzyz ="Opcion invalida.";
                                 Console.WriteLine(raptor_prompt_variable_zzyz);
                                 siNo= Double.Parse(Console.ReadLine());
                              }
                              if (siNo==1)
                              {
                                 Console.WriteLine("Se elimino "+productos(i)+" del inventario.");
                                 productos[i] = "";
                                 precios[i] = 0;
                                 cantidades[i] = 0;
                                 inventarioLleno =false;
                                 siNo =2;
                              }
                              else
                              {
                              }
                           }
                           else
                           {
                              Console.WriteLine("Producto no encontrado");
                           }
                           while (!(siNo==1 || siNo==2))
                           {
                              raptor_prompt_variable_zzyz ="Opcion invalida.";
                              Console.WriteLine(raptor_prompt_variable_zzyz);
                              siNo= Double.Parse(Console.ReadLine());
                           }
                           if (siNo==2)) break;
                        }
                     }
                     else
                     {
                     }
                  }
               }
            }
            if (menu==4)
            {
               raptor_prompt_variable_zzyz ="¿Desea salir?:  1.- no    2.- si";
               Console.WriteLine(raptor_prompt_variable_zzyz);
               siNo= Double.Parse(Console.ReadLine());
               while (!(siNo==1 || siNo==2))
               {
                  raptor_prompt_variable_zzyz ="Opcion invalida.";
                  Console.WriteLine(raptor_prompt_variable_zzyz);
                  siNo= Double.Parse(Console.ReadLine());
               }
            }
            else
            {
               if (inventarioLleno==true)
               {
                  raptor_prompt_variable_zzyz ="Ingrese el número de opción:  2.- Modificar   3.-Consultar   4 .- Salir  5.- Eliminar";
                  Console.WriteLine(raptor_prompt_variable_zzyz);
                  menu= Double.Parse(Console.ReadLine());
                  while (!(menu>1 && menu<6))
                  {
                     raptor_prompt_variable_zzyz ="Opción invalida, seleccione una opcion correcta ";
                     Console.WriteLine(raptor_prompt_variable_zzyz);
                     menu= Double.Parse(Console.ReadLine());
                  }
               }
               else
               {
                  if (InventarioVacio==true)
                  {
                     raptor_prompt_variable_zzyz ="Ingrese el número de opción: 1.- Agregar  2.- Modificar   3.-Consultar   4 .- Salir";
                     Console.WriteLine(raptor_prompt_variable_zzyz);
                     menu= Double.Parse(Console.ReadLine());
                     while (!(menu>0 && menu<5))
                     {
                        raptor_prompt_variable_zzyz ="Opción invalida, seleccione una opcion correcta ";
                        Console.WriteLine(raptor_prompt_variable_zzyz);
                        menu= Double.Parse(Console.ReadLine());
                     }
                  }
                  else
                  {
                     raptor_prompt_variable_zzyz ="Ingrese el número de opción: 1.- Agregar  2.- Modificar   3.-Consultar   4 .- Salir  5.- Eliminar";
                     Console.WriteLine(raptor_prompt_variable_zzyz);
                     menu= Double.Parse(Console.ReadLine());
                     while (!(menu>0 && menu<6))
                     {
                        raptor_prompt_variable_zzyz ="Opción invalida, seleccione una opcion correcta ";
                        Console.WriteLine(raptor_prompt_variable_zzyz);
                        menu= Double.Parse(Console.ReadLine());
                     }
                  }
               }
            }
            if (siNo==2)) break;
         }
         Console.WriteLine("Fin del programa");
      }
   }
}
