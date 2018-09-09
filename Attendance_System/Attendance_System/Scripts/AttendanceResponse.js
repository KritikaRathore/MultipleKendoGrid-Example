function change() {
    //var grid = $("#ClassSubjectGrid").data("kendoGrid");
    //var cls_sch_ID = grid.dataItem(grid.select()).ClassScheduleID;
    ////alert(cls_sch_ID);
    
    $("#StudentGrid").data("kendoGrid").dataSource.read();
}

function data() {
    var grid = $("#ClassSubjectGrid").data("kendoGrid");
    var cls_sch_ID = grid.dataItem(grid.select()).ClassScheduleID;
    //alert(cls_sch_ID);
    return {
        ClassScheduleID: cls_sch_ID
    };
}
function UpdateInsertdata() {
    var grid = $("#StudentGrid").data("kendoGrid");
    var cls_sch_ID = { ClassScheduleID: grid.dataItem(grid.select()).ClassScheduleID };
    var st = {
        StudentID: grid.dataItem(grid.select()).StudentID,
        FirstName: grid.dataItem(grid.select()).FirstName,
        MiddleName: grid.dataItem(grid.select()).MiddleName,
        LastName: grid.dataItem(grid.select()).LastName,
        Gender: grid.dataItem(grid.select()).Gender,
        DateofBirth: grid.dataItem(grid.select()).DateofBirth,
        AddressLine1: grid.dataItem(grid.select()).AddressLine1,
        AddressLine2: grid.dataItem(grid.select()).AddressLine2,
        City: grid.dataItem(grid.select()).City,
        Country: grid.dataItem(grid.select()).Country,
        PhoneNo: grid.dataItem(grid.select()).PhoneNo,
    }
    //alert(cls_sch_ID);
    return st;
}
function deletedata() {
    var grid = $("#StudentGrid").data("kendoGrid");
    var st_ID = grid.dataItem(grid.select()).StudentID;
    var att_id = grid.dataItem(grid.select()).AttendanceID;
    //alert(cls_sch_ID);
    return {
        StudentID: stID,
        AttendanceID : att_id
    };
}