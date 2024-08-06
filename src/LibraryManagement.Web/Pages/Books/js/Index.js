$(function () {
    var l = abp.localization.getResource('LibraryManagement');

    var dataTable = $('#BooksTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(libraryManagement.services.book.getList),
            columnDefs: [
                {
                    title: l("Title"),
                    data: "title"
                },
                {
                    title: l("Author"),
                    data: "author"
                },
                {
                    title: l("Genre"),
                    data: "genre",
                    render: function (data) {
                        return l('Enum:BookGenre.' + data)
                    }
                },
                {
                    title: l("Publisher"),
                    data: "publisher"
                },
            ]
        })
    )
})