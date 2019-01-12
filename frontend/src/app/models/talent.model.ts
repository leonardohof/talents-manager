export class Talent {
    id: number;
    name: String;
    email: String;
    skype: String;
    phone: String;
    linkedin: String;
    city: String;
    state: String;
    portfolio: String;
    upToFourHoursPerDay: Boolean;
    fourToSixHoursPerDay: Boolean;
    sixToHeightHoursPerDay: Boolean;
    upToEightHoursPerDay: Boolean;
    onlyWeekends: Boolean;
    workingMorning: Boolean;
    workingAfternoon: Boolean;
    workingNight: Boolean;
    workingDawn: Boolean;
    workingBusiness: Boolean;
    hourlySalary: String;
    skills: String[];

    constructor(data: any) {
        this.id = data.id || '';
        this.name = data.name || '';
        this.email = data.email || '';
        this.skype = data.skype || '';
        this.phone = data.phone || '';
        this.linkedin = data.linkedin || '';
        this.city = data.city || '';
        this.state = data.state || '';
        this.portfolio = data.portfolio || '';
        this.upToFourHoursPerDay = data.upToFourHoursPerDay || false;
        this.fourToSixHoursPerDay = data.fourToSixHoursPerDay || false;
        this.sixToHeightHoursPerDay = data.sixToHeightHoursPerDay || false;
        this.upToEightHoursPerDay = data.upToEightHoursPerDay || false;
        this.onlyWeekends = data.onlyWeekends || false;
        this.workingMorning = data.workingMorning || false;
        this.workingAfternoon = data.workingAfternoon || false;
        this.workingNight = data.workingNight || false;
        this.workingDawn = data.workingDawn || false;
        this.workingBusiness = data.workingBusiness || false;
        this.hourlySalary = data.hourlySalary || 0;
        this.skills = data.skills || [];
    }
}
