function preparationOfProjects(input) {

    let name = (input[0]);
    let projects = Number(input[1]);
    let hoursToCompleteOneProject = 3;

    //"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."

    let result = `The architect ${name} will need ${hoursToCompleteOneProject * projects} hours to complete ${projects} project/s.`

    console.log(result);

}

preparationOfProjects(["George", "4"]);