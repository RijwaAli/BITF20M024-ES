pipeline {
    agent any

    stages {
        stage('Checkout SCM') {
            steps {
                // Checkout SCM steps
                checkout scm
            }
        }
        stage('Build') {
            steps {
                // Add build steps here
                // Example: Maven build
                bat 'mvn clean install'
            }
        }
        stage('Test') {
            steps {
                // Add test steps here
                // Example: Execute tests
                bat 'mvn test'
            }
        }
        stage('Deploy') {
            steps {
                // Add deployment steps here
                // Example: Deploy artifacts
                bat 'mvn deploy'
            }
        }
        stage('Cleanup') {
            steps {
                // Add cleanup steps here
                // Example: Clean up temporary files
                bat 'del /q /s target'
            }
        }
        stage('Notify') {
            steps {
                // Add notification steps here
                // Example: Send notifications
                echo 'Sending notifications...'
            }
        }
    }

    post {
        success {
            // Actions to perform if the pipeline succeeds
            echo 'Pipeline execution completed successfully!'
            // Example: Apply FindBugs and PMD plugins
            recordIssues tools: [findBugs(pattern: '**/findbugs.xml'), pmdParser(pattern: '**/pmd.xml')]
        }
        failure {
            // Actions to perform if the pipeline fails
            echo 'Pipeline execution failed!'
            // You can add more actions here
        }
        always {
            // Actions to perform always, regardless of pipeline result
            echo 'Pipeline execution completed'
            // You can add cleanup actions here
        }
    }
    
    // Add the build step with a quiet period of 5 seconds for the 'test' job
    build job: 'test', quietPeriod: 5
}
