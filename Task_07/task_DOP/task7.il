
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 5:0:0:0
}
.assembly task
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 35 2E 30 01 00 54 0E 14   // ersion=v5.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 04 74 61 73 6B 00 00 )                      // ...task..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 07 52 65 6C 65 61 73 65 00 00 )             // ...Release..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 04 74 61 73 6B 00 00 )                      // ...task..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 04 74 61 73 6B 00 00 )                      // ...task..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module task.dll
// MVID: {499F4644-8C15-485B-925C-98A077CDDB14}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x07080000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit task.Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       114 (0x72)
    .maxstack  4
    .locals init (string V_0,
             string V_1)
    IL_0000:  ldstr      "Hello World!"
    IL_0005:  call       void [System.Console]System.Console::WriteLine(string)
    IL_000a:  ldstr      "Enter you name"
    IL_000f:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0014:  call       string [System.Console]System.Console::ReadLine()
    IL_0019:  stloc.0
    IL_001a:  ldstr      "How many age"
    IL_001f:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0024:  call       string [System.Console]System.Console::ReadLine()
    IL_0029:  stloc.1
    IL_002a:  ldstr      "Hello "
    IL_002f:  ldloc.0
    IL_0030:  ldstr      "! You are "
    IL_0035:  ldloc.1
    IL_0036:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string,
                                                                      string,
                                                                      string)
    IL_003b:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0040:  ldloc.1
    IL_0041:  call       int32 [System.Runtime]System.Convert::ToInt32(string)
    IL_0046:  ldc.i4.s   65
    IL_0048:  ble.s      IL_0054

    IL_004a:  ldstr      "you pensioner\!!!"
    IL_004f:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0054:  ldstr      "Do 100 let ostalos {0} let"
    IL_0059:  ldc.i4.s   100
    IL_005b:  ldloc.1
    IL_005c:  call       int32 [System.Runtime]System.Convert::ToInt32(string)
    IL_0061:  sub
    IL_0062:  box        [System.Runtime]System.Int32
    IL_0067:  call       string [System.Runtime]System.String::Format(string,
                                                                      object)
    IL_006c:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0071:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class task.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 C:\Users\IVG\Desktop\GeekBrains\Introduction_to_C\task7.res
