new DataTable('#tblData', {
    ajax: '/Customer/Product/GetAll',
    columns: [
        { data: 'title' },
        { data: 'isbn' },
        { data: 'price' },
        { data: 'author' },
        { data: 'category.name' },
        { defaultContent: '' }
    ]
});