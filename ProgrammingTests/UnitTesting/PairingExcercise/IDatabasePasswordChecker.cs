using System;

namespace PairingExercise
{
    public interface IDatabasePasswordChecker
    {
        bool DoesNewPasswordMatchPrevious6Passwords(string newPassword);
    }
}
