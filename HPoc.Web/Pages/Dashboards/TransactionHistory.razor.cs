using HPoc.Web.Results;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPoc.Web.Pages.Dashboards
{
    public partial class TransactionHistory : ComponentBase
    {
        [Parameter]public List<TransactionResult> Transactions { get; set; } = new();


        private async Task<TableData<Element>> ServerReload(TableState state)
        {
            int number = 0;
            IEnumerable<Element> data = Enumerable.Range(1, 11).Select(c =>
            {
                number += 1;
                return new Element()
                {
                    Molar = 1.9783 * number,
                    Name = $"hydrogen {number}",
                    Number = number,
                    Position = 1,
                    Sign = "H"
                };
            });
            data = data.Where(element =>
            {
                if (string.IsNullOrWhiteSpace(searchString))
                    return true;
                if (element.Sign.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    return true;
                if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    return true;
                if ($"{element.Number} {element.Position} {element.Molar}".Contains(searchString))
                    return true;
                return false;
            }).ToArray();
            totalItems = data.Count();
            switch (state.SortLabel)
            {
                case "nr_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Number);
                    break;
                case "sign_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Sign);
                    break;
                case "name_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Name);
                    break;
                case "position_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Position);
                    break;
                case "mass_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Molar);
                    break;
            }

            pagedData = data.Skip(state.Page * state.PageSize).Take(state.PageSize).ToArray();
            return new TableData<Element>() { TotalItems = totalItems, Items = pagedData };
        }

        private IEnumerable<Element> pagedData;
        private MudTable<Element> table;

        private int totalItems;
        private string searchString = null;

        /// <summary>
        /// Here we simulate getting the paged, filtered and ordered data from the server
        /// </summary>


        private void OnSearch(string text)
        {
            searchString = text;
            table.ReloadServerData();
        }
    }

    public class Element
    {
        public int Number { get; set; }
        public string Sign { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public double Molar { get; set; }
    }
}
