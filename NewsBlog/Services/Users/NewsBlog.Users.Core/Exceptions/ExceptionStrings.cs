namespace NewsBlog.Users.Core.Exceptions
{
    public static class ExceptionStrings
    {
        public static string NotFound => "Path not found";

        public static string UserNotFound => "User does not exist";

        public static string EmailIsBusy => "This email is already used";

        public static string EntityAlreadyExists => "entity already exists";

        public static string ExtensionNotSupported => "extension not supported";

        public static string UnexpectedErrorOccurred => "An unexpected error occurred";

        public static string FailedToLogin => "The password or the email are no correct";
    }
}
