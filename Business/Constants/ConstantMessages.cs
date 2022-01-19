using Entities.DBClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class ConstantMessages
    {
        public static string AlbumsListed = "Albums listed successfully";
        public static string AlbumYearWarning = "Year value cannot be less than zero";
        public static string AlbumStockWarning = "Stock value cannot be less than zero";
        public static string AlbumWarning = "Year value cannot be less than zero";
        public static string FluentValidationUnValidClass = "The class you entered is not a valid class";
        public static string RecordAlreadyExist = "The record you entered already exists";
        public static string AlbumAdded = "Album added successfully";
        public static string AlbumDeleted = "Album deleted successfully";
        public static string AlbumUpdated = "Album updated successfully";
        public static string UserNotFound = "User not found";
        public static string LoginSuccessful = "Login successful";
    }
}
