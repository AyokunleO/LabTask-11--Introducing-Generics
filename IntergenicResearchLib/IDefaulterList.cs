using System;
namespace IntergenicResearchLib
{
    public interface IDefaulterList
    {
         string GetName();
         int GetYear();
         Book GetBook();
         DateTime GetDateIssue();
         DateTime GetDateReturn();
         string GetDefaulter();

    }
}