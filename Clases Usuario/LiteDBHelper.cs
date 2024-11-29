using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace TiendaVideojuegosSimulador
{
    public static class LiteDBHelper
    {
        private const string DatabasePath = @"TiendaVideojuegos.db"; // Ruta de la base de datos

        // Método para insertar un nuevo registro en una colección
        public static bool Insert<T>(string collectionName, T data)
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var collection = db.GetCollection<T>(collectionName);
                var id = collection.Insert(data); // Inserta el dato y devuelve el ID
                return id != null; // Devuelve true si la inserción fue exitosa
            }
        }

        // Método para obtener todos los registros de una colección
        public static List<T> GetAll<T>(string collectionName)
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var collection = db.GetCollection<T>(collectionName);
                return collection.FindAll().ToList();
            }
        }

        // Método para buscar un registro por ID
        public static T GetById<T>(string collectionName, int id) where T : class
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var collection = db.GetCollection<T>(collectionName);
                return collection.FindById(id);
            }
        }

        // Método para buscar registros con un filtro
        public static List<T> GetByFilter<T>(string collectionName, System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var collection = db.GetCollection<T>(collectionName);
                return collection.Find(predicate).ToList();
            }
        }

        // Método para actualizar un registro existente
        public static bool Update<T>(string collectionName, T data)
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var collection = db.GetCollection<T>(collectionName);
                return collection.Update(data); // Devuelve true si la actualización fue exitosa
            }
        }

        // Método para eliminar un registro por ID
        public static bool DeleteById<T>(string collectionName, int id)
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var collection = db.GetCollection<T>(collectionName);
                return collection.Delete(id); // Devuelve true si la eliminación fue exitosa
            }
        }

        // Método para eliminar todos los registros en una colección
        public static int DeleteAll<T>(string collectionName)
        {
            using (var db = new LiteDatabase(DatabasePath))
            {
                var collection = db.GetCollection<T>(collectionName);
                return collection.DeleteMany(_ => true); // Devuelve la cantidad de registros eliminados
            }
        }
    }
}
