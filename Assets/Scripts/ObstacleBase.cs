using UnityEngine;


// 1. ABSTRACTION: Gunakan abstract class
public abstract class ObstacleBase : MonoBehaviour
{
    // 2. INHERITANCE: Properti umum diwarisi oleh semua anak
    // Menggunakan protected agar child class bisa akses
    [SerializeField] protected float speed = 2f;
    [SerializeField] protected float destroyXPosition = -10f;

    // 3. ABSTRACTION: Method abstrak yang WAJIB diimplementasikan oleh anak
    // Anak harus mendefinisikan "bagaimana cara Move"
    public abstract void Move();

    // Method umum (Diwarisi)
    protected void CheckDestroy()
    {
        // Logic menghancurkan objek ketika melewati layar
        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }

    // VIRTUAL: Child class bisa override jika perlu
    protected virtual void Update()
    {
        // 4. POLYMORPHISM: Panggil Move() yang sudah diimplementasikan anak
        Move();
        CheckDestroy();
    }
}
