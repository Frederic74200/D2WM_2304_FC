class CreateMail {

    constructor(_fullname) {
        this.name = _fullname
    }


    createEMail() {
        this.name = this.name.split(' ');
        let firstName = this.name[0];
        return firstName[0].toLowerCase() + "." + this.name[1].toLowerCase() + '@email.com';
    }

}
export { CreateMail }