using UnityEngine;

public static class Easing 
{
   public static float EaseOutSine(float i) => Mathf.Sin((i * Mathf.PI) / 2);
   public static float EaseInSine(float i) => 1 - Mathf.Cos(i * Mathf.PI / 2);
   public static float EaseInOutSine(float i) => -(Mathf.Cos(Mathf.PI * i) - 1) / 2;
}
