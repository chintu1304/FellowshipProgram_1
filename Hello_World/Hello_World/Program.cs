// See https://aka.ms/new-console-template for more informat
using Hello_World;
using Hello_World.uc9; 
using Hello_World.UcFinalSolution;

Console.WriteLine("Hello, World!");
UC1_EmployeePresent.GetAttendance();
//UC2_EmpWage.EmpWage();
//UC3_PartTimeEmpWage.PartTimeEmpWage();
//UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("jio", 30, 21, 168);

//#region UC9
//EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
//EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
//dMart.computeEmpWage();
//Console.WriteLine(dMart.toString());
//reliance.computeEmpWage();
//Console.WriteLine(reliance.toString());
//#endregion  UC9Ending

//#region UC10
//EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
//empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();
//#endregion

//#region FinalSolution
//EmpWageBuilder empWageBuild = new EmpWageBuilder();
//empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
//empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuild.computeEmpWage();
//#endregion

Console.ReadKey();

