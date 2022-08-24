using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        float CylinderRadius = Inputfloat("円柱の半径を入力してください");
        float CylinderHeight = Inputfloat("円柱の高さを入力してください");
        Cylinder cylinder= new Cylinder(CylinderRadius,CylinderHeight);
        float CylinderSurface = cylinder.GetCylinderSurface();
        float CylinderVolume= cylinder.GetCylinderVolume();
        Console.WriteLine($"円柱の表面積は{CylinderSurface}");
        Console.WriteLine($"円柱の体積は{CylinderVolume}");

        float SphereRadius = Inputfloat("球の半径を入力してください");
        Sphere sphere = new Sphere(SphereRadius);
        float SphereSurface= sphere.GetSphereSurface();
        float SphereVolume= sphere.GetSphereVolume();
        Console.WriteLine($"球の表面積は{SphereSurface}");
        Console.WriteLine($"球の体積は{SphereVolume}");

        float TriangularSide = Inputfloat("三角柱の二辺の長さを入力してください");
        float TriangularHeight = Inputfloat("三角柱の高さを入力してください");
        Triangular triangular= new Triangular(TriangularSide, TriangularHeight);
        float TriangularSurface=triangular.GetTriangularSurface();
        float TriangularVolume = triangular.GetTriangularVolume();
        Console.WriteLine($"三角柱の表面積は{TriangularSurface}");
        Console.WriteLine($"三角柱の体積は{TriangularVolume}");

    }

    static float Inputfloat(string s)
    {
        while (true)
        {
            Console.WriteLine(s);
            try
            {
                float a=float.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("入力エラー");
                }
                else
                {
                    return a;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("数字を入れてください");
            }
        }
    }
}

class Cylinder
{
    float CylinderRadius;
    float CylinderHeight;

    public Cylinder(float CylinderRadius, float CylinderHeight)
    {
        this.CylinderRadius = CylinderRadius;
        this.CylinderHeight = CylinderHeight;
    }

    public float GetCylinderSurface()
    {
        return CylinderRadius * CylinderRadius * (float)Math.PI+(float)Math.PI*CylinderHeight;
    }
    public float GetCylinderVolume()
    {
        return CylinderRadius * CylinderRadius * (float)Math.PI * CylinderHeight;
    }
}

class Sphere
{
    float SphereRadius;
    
    public Sphere(float Sphere)
    {
        this.SphereRadius = Sphere;
    }

    public float GetSphereSurface()
    {
        return 4 * (float)Math.PI * SphereRadius * SphereRadius;
    }
    public float GetSphereVolume()
    {
        return (float)4/(float)3*(float)Math.PI*SphereRadius*SphereRadius*SphereRadius;
    }
}

class Triangular
{
    float TriangularSide;
    float TriangularHeight;

    public Triangular(float triangularSide, float triangularHeight)
    {
        TriangularSide = triangularSide;
        TriangularHeight = triangularHeight;
    }
    public float GetTriangularSurface()
    {
        return TriangularSide*TriangularSide //底面2つ
            +TriangularSide*TriangularHeight*2//大きさが等しい側面2つ
            +(float)Math.Sqrt(2)*TriangularSide*TriangularHeight;//
    }
    public float GetTriangularVolume()
    {
        return TriangularSide * TriangularSide / (float)2 * TriangularHeight;
    }
}