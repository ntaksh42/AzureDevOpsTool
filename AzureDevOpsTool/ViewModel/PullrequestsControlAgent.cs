﻿using System.Text;
using AzureDevOps.Service;
using AzureDevOpsTool.Controls;
using Microsoft.TeamFoundation.Core.WebApi;
using Microsoft.TeamFoundation.SourceControl.WebApi;
using static AzureDevOpsTool.Controls.PrSearchConditionForm;

namespace AzureDevOpsTool.ViewModel
{
    internal class PullRequestsControlAgent : PullRequestsControl.INeed
    {
        private readonly GitServiceContext _context;
        private readonly PrSearchCondition _prSearchCondition 
                            = new("*", "*", new List<PullRequestStatus> { PullRequestStatus.All});

        public string SearchConditionPreView 
            => $"#CreatedBy:{string.Empty},#ReviewedBy{string.Empty},#Status:{string.Empty}";

        public PrSearchCondition SearchCondition => _prSearchCondition;

        public PullRequestsControlAgent(GitServiceContext context)
        {
            _context = context;
        }

        public string[] GetTargetProjectCandidates()
        {
            var client = _context.Connection.GetClient<ProjectHttpClient>();
            return client.GetProjects().Result.Select(p => p.Name).ToArray();
        }

        public string[] GetTargetReposCandidates(string projectName)
        {
            var client = _context.Connection.GetClient<GitHttpClient>();
            return client.GetRepositoriesAsync(projectName).Result.Select(r => r.Name).ToArray();
        }

        public string GetPullRequestsInfo(string targetRepos, PullRequestStatus status)
        {
            var pullRequsts = ServiceEntry.GetPullRequestsInfo(targetRepos, status, _context);
            var sb = new StringBuilder();

            sb.AppendLine("Title,CreatedBy,Description,ClosedDate");
            foreach (var pr in pullRequsts)
            {
                sb.AppendLine($"{pr.Title},{pr.CreatedBy.DisplayName}, {pr.Description.Replace(",", string.Empty)},{pr.ClosedDate.ToString()}");
            }
            return sb.ToString();
        }

        public string GetUniqueCsvFileName()
            => $"work_{DateTime.Now.ToString("yyMMddHHmmss")}.csv";

        public void SaveToCsv(string srcStrings, FileInfo dstFileInfo)
           => File.WriteAllText(dstFileInfo.FullName, srcStrings);
    }
}
