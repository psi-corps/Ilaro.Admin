using System.Collections.Generic;
using Ilaro.Admin.Core.Models;
using Microsoft.AspNetCore.Http;

namespace Ilaro.Admin.Core.Data
{
    public interface IEntityService
    {
        string Create(
            Entity entity, 
            FormCollection collection,
            IFormFileCollection files);

        bool Edit(
            Entity entity,
            string key,
            FormCollection collection,
            IFormFileCollection files,
            object concurrencyCheckValue = null);

        bool Delete(
            Entity entity,
            string key,
            IEnumerable<PropertyDeleteOption> options);

        IList<GroupProperties> PrepareGroups(
            EntityRecord entityRecord,
            bool getKey = true,
            string key = null);
    }
}