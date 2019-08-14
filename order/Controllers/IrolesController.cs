using System.Web.Mvc;

namespace order.Controllers
{
    public interface IrolesController
    {
        ActionResult Create();
        ActionResult Create([Bind(Include = "r_id,r_name,r_status")] role role);
        ActionResult Delete(int? id);
        ActionResult DeleteConfirmed(int id);
        ActionResult Details(int? id);
        ActionResult Edit(int? id);
        ActionResult Edit([Bind(Include = "r_id,r_name,r_status")] role role);
        ActionResult Index();
    }
}