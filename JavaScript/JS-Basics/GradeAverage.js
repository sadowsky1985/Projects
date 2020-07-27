  
  const array = [70];

  console.log(calculateGrade(array));
  
    function calculateGrade(marks){
        const average = calculateAverage(marks)  
        if (avg < 60) return 'F';
        if (avg < 70) return 'D';
        if (avg < 80) return 'C';
        if (avg < 90) return 'B';
        return 'A';
    }
    
    function calculateAverage(array){
        let sum = 0;
        for (value of array)
            sum += value;
        return sum / array.length;
        
  }