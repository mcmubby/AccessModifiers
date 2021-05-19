using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Private 
            // 2. Protected
            // 3. Internal
            // 4. Protected Internal
            // 5. Public

            // Private members are available only within the containing type.

            // Public members are available anywhere.

            // Protected member are available within containing type and to the types
            // that derive from the containing type.

            // Internal members are not accessible outside the assembly in which they
            // are contained.

            // Protected Internal is available to all members in the assembly and to 
            // any member that inherits from the type outside the assembly.

            // Only public and internal can be assigned to types(class,struct,interface,delegates).
            // If you don't specify access modifiers for types, it will have internal as the
            // default.
            // Type members can have all access modifiers.
            // If you don't specify access modifiers for type members, it will be assigned 
            // private by default.
        }
    }
}
