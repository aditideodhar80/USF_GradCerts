// this function is used to show news delete confirmation dialog box
function confirm_delete(gridName)
{

var myGrid = igtbl_getGridById(gridName);
var myRow= myGrid.getActiveRow();
if (myRow != undefined)
    {
      if (confirm("Are you sure you want to delete the selected item?")==true)
            return true;
      else
            return false;
    }            
else
    {
        alert("No active item selected, please select one and then click Remove button.");
        return false;
     }


}