function numbers1ToNWithStep3(input) {
    let num = Number(input[0]);

    for (let i = 1; num >= i; i += 3) {
        console.log(i);
    }
}
numbers1ToNWithStep3(["14"]);