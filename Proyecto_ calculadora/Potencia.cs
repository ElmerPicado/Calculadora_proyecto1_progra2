namespace Proyecto_calculadora{
  internal class Potencia{
    public static float Potencia(float num1, float num2){
      float resultado = Math.Pow(num1, num2);
      return resultado;
    } 

    public static float PotenciaAlCuadrado(float num1){
      float resultado = Math.Pow(num1, 2);
      return resultado;
    }
  }
}
