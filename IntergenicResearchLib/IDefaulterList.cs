using System;
namespace IntergenicResearchLib
{
    public interface IDefaulterList
    {
         string GetName();
         int GetYear();
         string GetBook();
         Date GetDateIssue();
         Date GetDateReturn();
         string GetDefaulter();

    }
}