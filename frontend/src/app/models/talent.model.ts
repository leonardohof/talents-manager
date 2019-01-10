export class Talent {
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
    UpToEightHoursPerDay: Boolean;
    onlyWeekends: Boolean;
    workingMorning: Boolean;
    workingAfternoon: Boolean;
    workingNight: Boolean;
    workingDawn: Boolean;
    workingBusiness: Boolean;
    knowledges: TalentKnowledge[];
}

export class TalentKnowledge {
    knowledgeId: number;
    skillLevel: number;
}
