//FORM 1
function AddTemple() {
    ResetForm1();
    // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $('#addTempleModel');
    modal.find('#modal-title').text('Add new temple');
    modal.find('#modal-title').attr('formtype', 'temple');
    modal.find('#textbox1-header').text('Temple Title');
    modal.find('#textbox1-control').attr('placeholder', 'Add new temple title');
    modal.find('[tag="form1"]').show();
    modal.modal('show');
}
function AddCity() {
    ResetForm1();
    var modal = $('#addTempleModel');
    modal.find('#modal-title').text('Add new city')
    modal.find('#modal-title').attr('formtype', 'city')
    modal.find('#textbox1-header').text('City Title 1')
    modal.find('#textbox2-header').text('State')
    modal.find('#textbox3-header').text('Country')
    modal.find('#textbox1-control').attr('placeholder', 'Add new city title');
    modal.find('#textbox2-control').attr('placeholder', 'Add State')
    modal.find('#textbox3-control').attr('placeholder', 'Add Country')
    modal.find('[tag="form1"]').show()
    modal.find('[tag="form4"]').show()
    modal.modal('show')
}
function AddTrust() {
    ResetForm1()
    var modal = $('#addTempleModel')
    modal.find('#modal-title').text('Add new trust')
    modal.find('#modal-title').attr('formtype', 'trust')
    modal.find('#textbox1-header').text('Trust Title')
    modal.find('#textbox1-control').attr('placeholder', 'Add new trust title');
    modal.find('[tag="form1"]').show()
    modal.modal('show')
}

function ResetForm1() {
    var modal = $('#addTempleModel')
    modal.find('#modal-title').text('')
    modal.find('#modal-title').attr('formtype', '')
    modal.find('#listbox-header').text('')
    modal.find('#textbox1-header').text('')
    modal.find('#textbox2-header').text('')
    modal.find('#textbox3-header').text('')
    modal.find('#textbox1-control').val('')
    modal.find('#textbox2-control').val('')
    modal.find('#textbox3-control').val('')
    modal.find('#textbox1-control').attr('placeholder', '')
    modal.find('#textbox2-control').attr('placeholder', '')
    modal.find('#textbox3-control').attr('placeholder', '')
    modal.find('[tag="form1"]').hide()
    modal.find('[tag="form3"]').hide()
    modal.find('[tag="form4"]').hide()
}
function AddIdol() {
    ResetForm1()
    var modal = $('#addTempleModel')
    modal.find('#modal-title').text('Add new Idol')
    modal.find('#modal-title').attr('formtype', 'idol')
    modal.find('#listbox-header').text('Select Idol Type')
    modal.find('#textbox1-header').text('Idol Title')
    modal.find('#textbox1-control').attr('placeholder', 'Add new Idol title');
    modal.find('[tag="form1"]').show()
    modal.find('[tag="form3"]').show()
    modal.modal('show')
}

function SubmitRecord() {
    var modal = $('#addTempleModel');
    var data = {
        title: modal.find('#textbox1-control').val(),
        formtype: modal.find('#modal-title').attr('formtype'),
        text2: modal.find('#textbox3-control').val(),
        text3: modal.find('#textbox2-control').val(),
        text4: modal.find('#listbox-control :Selected').val()
    };
    services.postService("submitnewentry", JSON.stringify(data), function (response) {
        console.log(response);
    });
}
//FORM 2
function ResetForm2() {
    console.log('Form Reset')
    var modal = $('#addTemplePropertyModel')

    modal.find('#modal-title').text('')
    modal.find('#modal-title').attr('formtype', '')
    modal.find('#label1-header').text('')
    modal.find('#label1-text').val('')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').val('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('')
    modal.find('#listbox-control').html('')
    modal.find('#filebox-header').text('')
    modal.find('#filebox-control').val('')
    modal.find('[tag="listbox"]').hide()
    modal.find('[tag="textbox"]').hide()
    modal.find('[tag="filebox"]').hide()
}

//FORM 2
function AddTempleCity() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple City')
    modal.find('#modal-title').attr('formtype', 'temple-city')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').val('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('City ')
    modal.find('#listbox-control').html('<option>---Select City---</option>')
    modal.find('#filebox-header').text('')
    modal.find('#filebox-control').val('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddContactDetails() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Contact Details')
    modal.find('#modal-title').attr('formtype', 'temple-contactdetails')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('Contact Details')
    modal.find('#textbox-control').attr('placeholder', 'Please enter Contact Details')
    modal.find('#listbox-header').text('')
    modal.find('#listbox-control').html('<option>---Select City---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddContactNumber() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Contact Number')
    modal.find('#modal-title').attr('formtype', 'temple-contactnumber')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('Contact Number')
    modal.find('#textbox-control').attr('placeholder', 'Please enter Contact Number')
    modal.find('#listbox-header').text('')
    modal.find('#listbox-control').html('<option>---Select City---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddMoolnayak() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Moolnayak')
    modal.find('#modal-title').attr('formtype', 'temple-mainidol')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('Moolnayak')
    modal.find('#listbox-control').html('<option>---Select Moolnayak---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddMoolnayakImage() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Moolnayak Image')
    modal.find('#modal-title').attr('formtype', 'temple-mainidolimage')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('')
    modal.find('#listbox-control').html('<option>---Select Moolnayak---</option>')
    modal.find('#filebox-header').text('Moolnayak Image')
    modal.find('[tag="filebox"]').show()
    modal.modal('show')
}

function AddTempleImage() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Image')
    modal.find('#modal-title').attr('formtype', 'temple-image')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('')
    modal.find('#listbox-control').html('<option>---Select Moolnayak---</option>')
    modal.find('#filebox-header').text('Temple Image')
    modal.find('[tag="filebox"]').show()
    modal.modal('show')
}

function AddTempleTrust() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Trust')
    modal.find('#modal-title').attr('formtype', 'temple-trust')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('Trust')
    modal.find('#listbox-control').html('<option>---Select Trust---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddTempleOtherIdols() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Other Idol')
    modal.find('#modal-title').attr('formtype', 'temple-otheridol')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('Other Idol')
    modal.find('#listbox-control').html('<option>---Select Other Idol---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddTempleYaksh() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Yaksh')
    modal.find('#modal-title').attr('formtype', 'temple-yaksh')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('Yaksh')
    modal.find('#listbox-control').html('<option>---Select Yaksh---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddTempleDevis() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Devis')
    modal.find('#modal-title').attr('formtype', 'temple-devis')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('Devis')
    modal.find('#listbox-control').html('<option>---Select Devis---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddTempleGuruMaharaj() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple GuruMaharaj')
    modal.find('#modal-title').attr('formtype', 'temple-gurumaharaj')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('GuruMaharaj')
    modal.find('#listbox-control').html('<option>---Select GuruMaharaj---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddTemplePagla() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Update Temple Charan/Pagla')
    modal.find('#modal-title').attr('formtype', 'temple-charanpagla')
    modal.find('#label1-header').text('Temple Name')
    modal.find('#label1-text').val('Shree Pancha Dera')
    modal.find('#textbox-header').text('')
    modal.find('#textbox-control').attr('placeholder', '')
    modal.find('#listbox-header').text('Charan / Pagla')
    modal.find('#listbox-control').html('<option>---Select Charan/Pagla---</option>')
    modal.find('#filebox-header').text('')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function SubmitForm2() {
    var modal = $('#addTemplePropertyModel')
    var data = {
        key1: modal.find('#label1-text').val(),
        formtype: modal.find('#modal-title').attr('formtype'),
        title: modal.find('#textbox-control').val(),
        text1: modal.find('#listbox-control :Selected').val()
    }
    services.postService("submitform2", JSON.stringify(data), function (response) {
        console.log(response);
    })
}

function SubmitForm3() {
    var modal = $('#addCityPropertyModel')
    var data = {
        key1: modal.find('#label1-text').val(),
        formtype: modal.find('#modal-title').attr('formtype'),
        title: modal.find('#textbox1-control').val(),
        text1: modal.find('#textbox2-control').val(),
        text2: modal.find('#textbox3-control').val()
    };
    services.postService("submitform3", JSON.stringify(data), function (response) {
        console.log(response);
    });
}

function ResetForm3() {
    var modal = $('#addCityPropertyModel');
    modal.find('#modal-title').text('');
    modal.find('#modal-title').attr('formtype', '');
    modal.find('#label1-header').text('');
    modal.find('#label1-text').val('');
    modal.find('#listbox-header').text('');
    modal.find('#textbox1-header').text('');
    modal.find('#textbox2-header').text('');
    modal.find('#textbox3-header').text('');
    modal.find('#textbox1-control').val('');
    modal.find('#textbox2-control').val('');
    modal.find('#textbox3-control').val('');
    modal.find('#textbox1-control').attr('placeholder', '');
    modal.find('#textbox2-control').attr('placeholder', '');
    modal.find('#textbox3-control').attr('placeholder', '');
    modal.find('[tag="titlebox"]').hide();
    modal.find('[tag="value1box"]').hide();
    modal.find('[tag="value2box"]').hide();
}

function AddCityLocation() {
    ResetForm3()
    var modal = $('#addCityPropertyModel')
    modal.find('#modal-title').text('Update city location')
    modal.find('#modal-title').attr('formtype', 'city-location')
    modal.find('#label1-header').text('City')
    modal.find('#label1-text').val('Ahmedabad')
    modal.find('#textbox1-header').text('Latitude')
    modal.find('#textbox2-header').text('Longitude')
    modal.find('#textbox1-control').attr('placeholder', 'Latitude')
    modal.find('#textbox2-control').attr('placeholder', 'Longitude')
    modal.find('[tag="value1box"]').show()
    modal.find('[tag="value2box"]').show()
    modal.modal('show')
}

function AddBhs() {
    ResetForm3()
    var modal = $('#addCityPropertyModel')
    modal.find('#modal-title').text('Add new bhojanshala')
    modal.find('#modal-title').attr('formtype', 'city-bhojanshala')
    modal.find('#label1-header').text('City')
    modal.find('#label1-text').val('Ahmedabad')
    modal.find('#textbox1-header').text('Bhojanshala Title')
    modal.find('#textbox1-control').attr('placeholder', 'Enter bhojanshala title')
    modal.find('[tag="value1box"]').show()
    modal.modal('show')
}

function AddDhs() {
    ResetForm3()
    console.log('addCityPropertyModel')
    var modal = $('#addCityPropertyModel')
    modal.find('#modal-title').text('Add new dharmshala')
    modal.find('#modal-title').attr('formtype', 'city-dharmshala')
    modal.find('#label1-header').text('City')
    modal.find('#label1-text').val('Ahmedabad')
    modal.find('#textbox1-header').text('Dharmshala Title')
    modal.find('#textbox1-control').attr('placeholder', 'Enter dharmshala title')
    modal.find('[tag="value1box"]').show()
    modal.modal('show')
}

function AddApsr() {
    ResetForm3()
    console.log('addCityPropertyModel')
    var modal = $('#addCityPropertyModel')
    modal.find('#modal-title').text('Update apasara')
    modal.find('#modal-title').attr('formtype', 'city-apasara')
    modal.find('#label1-header').text('City')
    modal.find('#label1-text').val('Ahmedabad')
    modal.find('#textbox1-header').text('Apasara Title')
    modal.find('#textbox1-control').attr('placeholder', 'Enter apasara title')
    modal.find('[tag="value1box"]').show()
    modal.modal('show')
}


//FORM 2
function AddBhsAddress() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add Bhs Address')
    modal.find('#modal-title').attr('formtype', 'bhs-address')
    modal.find('#label1-header').text('BHS Title')
    modal.find('#label1-text').val('Shree PDT Bhnly')
    modal.find('#textbox-header').text('Bhs Adress')
    modal.find('#textbox-control').attr('placeholder', 'Please enter bhs address')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddBhsContactNumbers() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add Bhs Contact Numbers')
    modal.find('#modal-title').attr('formtype', 'bhs-ContactNumbers')
    modal.find('#label1-header').text('BHS Title')
    modal.find('#label1-text').val('Shree PDT Bhnly')
    modal.find('#textbox-header').text('Bhs Contact Numbers')
    modal.find('#textbox-control').attr('placeholder', 'Please enter bhs Contact Numbers')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddBhsTrust() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add Bhs Trust')
    modal.find('#modal-title').attr('formtype', 'bhs-Trust')
    modal.find('#label1-header').text('BHS Title')
    modal.find('#label1-text').val('Shree PDT Bhnly')
    modal.find('#listbox-header').text('Bhs Trust')
    modal.find('#listbox-control').html('<option>---Trust---</option>')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddBhsContactPerson() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add Bhs Contact Person')
    modal.find('#modal-title').attr('formtype', 'bhs-ContactPerson')
    modal.find('#label1-header').text('BHS Title')
    modal.find('#label1-text').val('Shree PDT Bhnly')
    modal.find('#textbox-header').text('Bhs Contact Person')
    modal.find('#textbox-control').attr('placeholder', 'Please enter bhs Contact Person')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddDhsAddress() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add Dhs Address')
    modal.find('#modal-title').attr('formtype', 'dhs-address')
    modal.find('#label1-header').text('DHS Title')
    modal.find('#label1-text').val('Shree PDT Dhnly')
    modal.find('#textbox-header').text('Dhs Adress')
    modal.find('#textbox-control').attr('placeholder', 'Please enter dhs address')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddDhsContactNumbers() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add Dhs Contact Numbers')
    modal.find('#modal-title').attr('formtype', 'dhs-ContactNumbers')
    modal.find('#label1-header').text('DHS Title')
    modal.find('#label1-text').val('Shree PDT Dhnly')
    modal.find('#textbox-header').text('Dhs Contact Numbers')
    modal.find('#textbox-control').attr('placeholder', 'Please enter dhs Contact Numbers')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddDhsTrust() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add dhs Trust')
    modal.find('#modal-title').attr('formtype', 'dhs-Trust')
    modal.find('#label1-header').text('DHS Title')
    modal.find('#label1-text').val('Shree PDT Dhnly')
    modal.find('#listbox-header').text('Dhs Trust')
    modal.find('#listbox-control').html('<option>---Trust---</option>')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddDhsContactPerson() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add Dhs Contact Person')
    modal.find('#modal-title').attr('formtype', 'dhs-ContactPerson')
    modal.find('#label1-header').text('DHS Title')
    modal.find('#label1-text').val('Shree PDT Dhnly')
    modal.find('#textbox-header').text('Dhs Contact Person')
    modal.find('#textbox-control').attr('placeholder', 'Please enter dhs Contact Person')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddAPSAddress() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add APS Address')
    modal.find('#modal-title').attr('formtype', 'APS-address')
    modal.find('#label1-header').text('APS Title')
    modal.find('#label1-text').val('Shree PDT APS')
    modal.find('#textbox-header').text('APS Adress')
    modal.find('#textbox-control').attr('placeholder', 'Please enter APS address')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddAPSContactNumbers() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add APS Contact Numbers')
    modal.find('#modal-title').attr('formtype', 'APS-ContactNumbers')
    modal.find('#label1-header').text('APS Title')
    modal.find('#label1-text').val('Shree PDT APS')
    modal.find('#textbox-header').text('APS Contact Numbers')
    modal.find('#textbox-control').attr('placeholder', 'Please enter APS Contact Numbers')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}

function AddAPSTrust() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add APS Trust')
    modal.find('#modal-title').attr('formtype', 'APS-Trust')
    modal.find('#label1-header').text('APS Title')
    modal.find('#label1-text').val('Shree PDT APS')
    modal.find('#listbox-header').text('APS Trust')
    modal.find('#listbox-control').html('<option>---Trust---</option>')
    modal.find('[tag="listbox"]').show()
    modal.modal('show')
}

function AddAPSContactPerson() {
    ResetForm2()
    console.log('addTemplePropertyModel')
    var modal = $('#addTemplePropertyModel')
    modal.find('#modal-title').text('Add APS Contact Person')
    modal.find('#modal-title').attr('formtype', 'APS-ContactPerson')
    modal.find('#label1-header').text('APS Title')
    modal.find('#label1-text').val('Shree PDT APS')
    modal.find('#textbox-header').text('APS Contact Person')
    modal.find('#textbox-control').attr('placeholder', 'Please enter APS Contact Person')
    modal.find('[tag="textbox"]').show()
    modal.modal('show')
}